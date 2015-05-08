using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace SystemFileWatcherGUI
{
    public partial class MainForm : Form
    {
        private FileSystemWatcher watcher;
        private LinkedList<MyFileSystemEventArgWrapper> files;
        private SQLiteConnection sqlite_conn;
        private SQLiteCommand sqlite_cmd;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopButton.Enabled = false;
            stopToolStripMenuItem.Enabled = false;
            files = new LinkedList<MyFileSystemEventArgWrapper>();
        }

        public class MyFileSystemEventArgWrapper
        {
            private String name;
            private String path;
            private String eventType;
            private String datetime;

            public String Name { get { return this.name; } }
            public String Path { get { return this.path; } }
            public String EventType { get { return this.eventType; } }
            public String Datetime { get { return this.datetime; } }

            public MyFileSystemEventArgWrapper(String name, String path, String eventType)
            {
                this.name = name;
                this.path = path;
                this.eventType = eventType;
                this.datetime = DateTime.Now.ToString();
            }
        }

        private void startButton_click(object sender, EventArgs e)
        {
            if(isPath(directoryBox.Text) == true)
            {
                String path = directoryBox.Text;

                watcher = startFileSystemWatcher(path);

                // Start
                watcher.EnableRaisingEvents = true;

                // Prevent users from invalid settings changing until stopped.
                stopButton.Enabled = true;
                startButton.Enabled = false;
                stopToolStripMenuItem.Enabled = true;
                startToolStripMenuItem.Enabled = false;
                extensionMonitor.Enabled = false;
            }
            // Else ignore
        }

        private FileSystemWatcher startFileSystemWatcher(string path)
        {
            String watching = "**** " + DateTime.Now.ToShortDateString() + " Watching: " + path + " ****" + Environment.NewLine;
            writeToScreen(watching);

            FileSystemWatcher watcher = new FileSystemWatcher(path);

            // Set path
            watcher.Path = path;
            // Set filters
            watcher.NotifyFilter = NotifyFilters.FileName | NotifyFilters.LastWrite | NotifyFilters.DirectoryName | NotifyFilters.LastAccess;
            // Set to recurse subdirs
            watcher.IncludeSubdirectories = true;
            // Set extension filter
            watcher.Filter = "*" + extensionMonitor.Text;

            // Event Handlers
            watcher.Changed += new FileSystemEventHandler((sender, e) => OnChanged(sender, e));
            watcher.Created += new FileSystemEventHandler((sender, e) => OnChanged(sender, e));
            watcher.Deleted += new FileSystemEventHandler((sender, e) => OnChanged(sender, e));
            watcher.Renamed += new RenamedEventHandler((sender, e) => OnChanged(sender, e));
            
            return watcher;
        }

        private void writeToScreen(String s)
        {
            BeginInvoke(new Action(() =>
            {
                eventsBox.Text += s;
                eventsBox.SelectionStart = eventsBox.Text.Length;
                eventsBox.ScrollToCaret();
            }));
        }

        private void OnChanged(object source, FileSystemEventArgs eventArg)
        {
            string name = eventArg.Name.Substring(eventArg.Name.LastIndexOf("\\") + 1);
            string eventToLog = "NAME: " + name + ", PATH: " + eventArg.FullPath + 
                ", EVENT: " + eventArg.ChangeType + ", TIME: " + DateTime.Now.ToString() + Environment.NewLine;
            writeToScreen(eventToLog);

            // Maintain list of events to write to database.
            files.AddLast(new MyFileSystemEventArgWrapper(name, eventArg.FullPath, eventArg.ChangeType.ToString()));
        }

        private void OnRenamed(object source, RenamedEventArgs eventArg)
        {
            string oldName = eventArg.OldName.Substring(eventArg.Name.LastIndexOf("\\"));
            string name = eventArg.Name.Substring(eventArg.Name.LastIndexOf("\\"));
            string eventToLog = "OLD NAME: " + oldName + " NEW NAME: " + name + 
                ", PATH: " + eventArg.FullPath + ", EVENT: " + eventArg.ChangeType + ", TIME: " + DateTime.Now.ToString() + Environment.NewLine;
            writeToScreen(eventToLog);

            // Maintain list of events to write to database.
            files.AddLast(new MyFileSystemEventArgWrapper(name, eventArg.FullPath, eventArg.ChangeType.ToString()));
        }

        private void stopButton_click(object sender, EventArgs e)
        {
            watcher.EnableRaisingEvents = false;

            // Reenable user to change monitoring settings
            stopButton.Enabled = false;
            startButton.Enabled = true;
            stopToolStripMenuItem.Enabled = false;
            startToolStripMenuItem.Enabled = true;
            extensionMonitor.Enabled = true;
        }

        private void clearDatabaseButton_click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to clear the database?", "Clear Database", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                String databasePath = Path.Combine(Environment.CurrentDirectory, databaseBox.Text);
                // If given database file exists
                if (File.Exists(databasePath))
                {
                    File.Delete(databasePath);
                    makeNewDatabase();
                }
                else
                {
                    MessageBox.Show("That database file doesn't exist.");
                } 
            }
        }

        private void queryDatabaseButton_click(object sender, EventArgs e)
        {
            if (databaseBox.Text != "")
            {
                String databasePath = Path.Combine(Environment.CurrentDirectory, databaseBox.Text);
                // If given database file exists
                if (File.Exists(databasePath))
                {
                    QueryForm form = new QueryForm(sqlite_conn, databaseExtension.Text);
                    form.Show();
                }
                else // database file doesn't exist
                {
                    MessageBox.Show("That database file does not exist.");
                }
            }
            else
                MessageBox.Show("Enter a database file to query.");

        }

        private void writeToDatabaseButton_click(object sender, EventArgs e)
        {
            if(databaseBox.Text != "")
            {
                String databasePath = Path.Combine(Environment.CurrentDirectory, databaseBox.Text);
                // If given database file exists
                if(File.Exists(databasePath))
                {
                    openDatabase();
                }
                else // database file doesn't exist
                {
                    makeNewDatabase();
                }
                // Write to database
                writeToDatabase();
            }
            else
            {
                MessageBox.Show("Enter a database filename.");
            }
            
        }

        private void writeToDatabase()
        {
            foreach(MyFileSystemEventArgWrapper arg in files)
            {
                String name = arg.Name, path = arg.Path, eventType = arg.EventType, dateTime = arg.Datetime;
                String filter = databaseExtension.Text;
                String fileExtension = name.Substring(name.Length - filter.Length);

                if(fileExtension == filter)
                {
                    // Craft command
                    String command = "INSERT INTO WatchedFiles (name, path, eventType, timedate) VALUES ('" + name + "', '" + path + "', '" + eventType + "', '" + dateTime + "');";
                    sqlite_cmd.CommandText = command;
                    sqlite_cmd.ExecuteNonQuery(); 
                }  
            }
            files.Clear();
        }

        private void openDatabase() // Needs fixed apparently
        {
            String text = "Data Source=" + databaseBox.Text + ";Version=3;New=False;Compress=True;";
            // Create database connection
            sqlite_conn = new SQLiteConnection(text);
            // Open database connection
            sqlite_conn.Open();
        }

        private void makeNewDatabase()
        {
            openDatabase();
            // Instantiate sql command
            sqlite_cmd = sqlite_conn.CreateCommand();
            // Set command to create a table of watched files
            sqlite_cmd.CommandText = "CREATE TABLE WatchedFiles (name varchar(100), path varchar(300), eventType varchar(100), timedate varchar(50));";
            // Execute
            sqlite_cmd.ExecuteNonQuery();
        }

        private bool isPath(String path)
        {
            if (!(Directory.Exists(path)))
            {
                MessageBox.Show("Path does not exist. Please enter a valid path.");
                return false;
            }
            else if (!(Path.IsPathRooted(path)))
            {
                MessageBox.Show("Path is not absolute. Please enter a valid path.");
                return false;
            }
            return true;
        }

        private void aboutButton_click(object sender, EventArgs e)
        {
            MessageBox.Show("File System Watcher \nTyler Herrin \n2015", "About");
        }

        private void exitButton_click(object sender, EventArgs e)
        {
            // Attempt to close connection if it was opened.
            try { sqlite_conn.Close(); }
            catch { }

            Environment.Exit(0);
        }

        private void shortcutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("F1 - Shortcuts Menu \nF2 - About Menu \nCTRL+S - Start \nCTRL+F - Stop \nCTRL+E - Exit");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File System Watcher v1.0\nTyler Herrin\n2015");
        }
    }
}
