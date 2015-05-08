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
        public SQLiteConnection Connection { get { return this.sqlite_conn; } set { this.sqlite_conn = value; } }
        private SQLiteCommand sqlite_cmd;
        public SQLiteCommand Command { get { return this.sqlite_cmd; } set { this.sqlite_cmd = value; } }

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
                eventsBox.Clear();

                watcher = startFileSystemWatcher(path);

                // Start
                watcher.EnableRaisingEvents = true;

                // Prevent users from invalid settings changing until stopped.
                stopButton.Enabled = true;
                startButton.Enabled = false;
                stopToolStripMenuItem.Enabled = true;
                startToolStripMenuItem.Enabled = false;
                extensionMonitor.Enabled = false;
                databaseClearButton.Enabled = false;
                databaseWriteButton.Enabled = false;
                databaseQueryButton.Enabled = false;
                databaseToolStripMenuItem.Enabled = false;
                exitToolStripMenuItem.Enabled = false;
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
            databaseClearButton.Enabled = true;
            databaseWriteButton.Enabled = true;
            databaseQueryButton.Enabled = true;
            databaseToolStripMenuItem.Enabled = true;
            exitToolStripMenuItem.Enabled = true;
            
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
                    openDatabase();
                    QueryForm form = new QueryForm(Connection, databaseExtension.Text);
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
                String fileExtension;

                int extensionIndex = name.LastIndexOf('.');
                if (extensionIndex != -1)
                    fileExtension = name.Substring(name.LastIndexOf('.'));
                else
                    fileExtension = "";
                 

                if(fileExtension == filter)
                {
                    // Craft command
                    String command = "INSERT INTO WatchedFiles (Filename, Path, Event, DateAndTime, Extension) " +
                        "VALUES ('" + name + "', '" + path + "', '" + eventType + "', '" + dateTime + "', '" + fileExtension + "');";
                    sqlite_cmd.CommandText = command;
                    sqlite_cmd.ExecuteNonQuery(); 
                }  
            }
            files.Clear();
        }

        private void openDatabase()
        {
            String text = "Data Source=" + databaseBox.Text + ";Version=3;New=False;Compress=True;";
            // Create database connection
            Connection = new SQLiteConnection(text);
            // Open database connection
            Connection.Open();
            // Instantiate sql command
            Command = Connection.CreateCommand();
        }

        private void makeNewDatabase()
        {
            openDatabase();
            // Set command to create a table of watched files
            Command.CommandText = "CREATE TABLE WatchedFiles (Filename varchar(100), Path varchar(300), Event varchar(100), DateAndTime varchar(50), Extension varchar(15));";
            // Execute
            Command.ExecuteNonQuery();
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
            if (files.Count != 0)
            {
                DialogResult result = MessageBox.Show("Save contents to database before exiting?", "Save to database", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (databaseBox.Text != "")
                        writeToDatabaseButton_click(null, null);
                    else
                    {
                        MessageBox.Show("No database file specified.");
                    }
                }
                else close();
            }
            else close();   
        }
        
        private void close()
        {
            // Attempt to close connection if it was opened.
            try { Connection.Close(); }
            catch { }

            Environment.Exit(0);
        }

        private void shortcutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" F1 - Shortcuts Menu \n F2 - About Menu \n F3 - Help Menu \n CTRL+S - Start \n CTRL+F - Stop \n CTRL+W - Write to database \n CTRL+Q - Query Database \n CTRL+C Clear Database \n CTRL+E - Exit");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File System Watcher v1.0\nTyler Herrin\n2015");
        }

        private void realHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter a valid directory to monitor and press start. You must stop the directory watcher in order to perform any other actions.");
        }
    }
}
