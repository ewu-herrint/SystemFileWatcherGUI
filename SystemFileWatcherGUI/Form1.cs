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
    public partial class Form1 : Form
    {
        private FileSystemWatcher watcher;
        private LinkedList<FileSystemEventArgs> files;
        private SQLiteConnection sqlite_conn;
        private SQLiteCommand sqlite_cmd;
        private SQLiteDataReader sqlite_datareader;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopButton.Enabled = false;
            stopToolStripMenuItem.Enabled = false;
            files = new LinkedList<FileSystemEventArgs>();
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
            string eventToLog = "NAME: " + eventArg.Name + ", PATH: " + eventArg.FullPath + 
                ", EVENT: " + eventArg.ChangeType + ", TIME: " + DateTime.Now.ToString() + Environment.NewLine;
            writeToScreen(eventToLog);

            // Maintain list of events to write to database.
            files.AddLast(eventArg);
        }

        private void OnRenamed(object source, RenamedEventArgs eventArg)
        {
            string eventToLog = "OLD NAME: " + eventArg.OldName + " NEW NAME: " + eventArg.Name + 
                ", PATH: " + eventArg.FullPath + ", EVENT: " + eventArg.ChangeType + ", TIME: " + DateTime.Now.ToString() + Environment.NewLine;
            writeToScreen(eventToLog);

            // Maintain list of events to write to database.
            files.AddLast(eventArg);
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

        }

        private void queryDatabaseButton_click(object sender, EventArgs e)
        {

        }

        private void writeToDatabaseButton_click(object sender, EventArgs e)
        {
            if(databaseBox.Text != "")
            {
                String text = "Data Source=" + databaseBox.Text + ";Version=3;New=True;Compress=True;";
                sqlite_conn = new SQLiteConnection(text);
                sqlite_conn.Open();
            }
            else
            {
                MessageBox.Show("Enter a database filename.");
            }
            
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
