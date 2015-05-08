namespace SystemFileWatcherGUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shortcutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoryBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.databaseClearButton = new System.Windows.Forms.Button();
            this.databaseQuereButton = new System.Windows.Forms.Button();
            this.databaseBox = new System.Windows.Forms.TextBox();
            this.extensionMonitor = new System.Windows.Forms.ComboBox();
            this.databaseExtension = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.databaseWriteButton = new System.Windows.Forms.Button();
            this.eventsBox = new System.Windows.Forms.TextBox();
            this.writeToDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.fileSystemWatcherToolStripMenuItem,
            this.databaseToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(446, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitButton_click);
            // 
            // fileSystemWatcherToolStripMenuItem
            // 
            this.fileSystemWatcherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.fileSystemWatcherToolStripMenuItem.Name = "fileSystemWatcherToolStripMenuItem";
            this.fileSystemWatcherToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.fileSystemWatcherToolStripMenuItem.Text = "FileSystemWatcher";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.startToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startButton_click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopButton_click);
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.writeToDatabaseToolStripMenuItem,
            this.queryDatabaseToolStripMenuItem,
            this.clearDatabaseToolStripMenuItem});
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.CheckOnClick = true;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shortcutsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.aboutButton_click);
            // 
            // shortcutsToolStripMenuItem
            // 
            this.shortcutsToolStripMenuItem.Name = "shortcutsToolStripMenuItem";
            this.shortcutsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.shortcutsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.shortcutsToolStripMenuItem.Text = "Shortcuts";
            this.shortcutsToolStripMenuItem.Click += new System.EventHandler(this.shortcutsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // directoryBox
            // 
            this.directoryBox.Location = new System.Drawing.Point(195, 84);
            this.directoryBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.directoryBox.Name = "directoryBox";
            this.directoryBox.Size = new System.Drawing.Size(222, 20);
            this.directoryBox.TabIndex = 1;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(195, 107);
            this.startButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 24);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(340, 107);
            this.stopButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 24);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Directory to monitor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Database";
            this.label2.Click += new System.EventHandler(this.stopButton_click);
            // 
            // databaseClearButton
            // 
            this.databaseClearButton.Location = new System.Drawing.Point(359, 223);
            this.databaseClearButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.databaseClearButton.Name = "databaseClearButton";
            this.databaseClearButton.Size = new System.Drawing.Size(56, 29);
            this.databaseClearButton.TabIndex = 7;
            this.databaseClearButton.Text = "Clear";
            this.databaseClearButton.UseVisualStyleBackColor = true;
            this.databaseClearButton.Click += new System.EventHandler(this.clearDatabaseButton_click);
            // 
            // databaseQuereButton
            // 
            this.databaseQuereButton.Location = new System.Drawing.Point(298, 223);
            this.databaseQuereButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.databaseQuereButton.Name = "databaseQuereButton";
            this.databaseQuereButton.Size = new System.Drawing.Size(56, 29);
            this.databaseQuereButton.TabIndex = 6;
            this.databaseQuereButton.Text = "Query";
            this.databaseQuereButton.UseVisualStyleBackColor = true;
            this.databaseQuereButton.Click += new System.EventHandler(this.queryDatabaseButton_click);
            // 
            // databaseBox
            // 
            this.databaseBox.Location = new System.Drawing.Point(195, 200);
            this.databaseBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.databaseBox.Name = "databaseBox";
            this.databaseBox.Size = new System.Drawing.Size(222, 20);
            this.databaseBox.TabIndex = 5;
            // 
            // extensionMonitor
            // 
            this.extensionMonitor.FormattingEnabled = true;
            this.extensionMonitor.Items.AddRange(new object[] {
            ".txt",
            ".doc",
            ".wmv",
            ".ini",
            ".tmp"});
            this.extensionMonitor.Location = new System.Drawing.Point(32, 83);
            this.extensionMonitor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.extensionMonitor.Name = "extensionMonitor";
            this.extensionMonitor.Size = new System.Drawing.Size(101, 21);
            this.extensionMonitor.TabIndex = 10;
            // 
            // databaseExtension
            // 
            this.databaseExtension.FormattingEnabled = true;
            this.databaseExtension.Items.AddRange(new object[] {
            ".txt",
            ".doc",
            ".wmv",
            ".ini",
            ".tmp"});
            this.databaseExtension.Location = new System.Drawing.Point(32, 200);
            this.databaseExtension.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.databaseExtension.Name = "databaseExtension";
            this.databaseExtension.Size = new System.Drawing.Size(101, 21);
            this.databaseExtension.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Extension to monitor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Query or write by extension";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 266);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "File System Watcher Events";
            // 
            // databaseWriteButton
            // 
            this.databaseWriteButton.Location = new System.Drawing.Point(195, 223);
            this.databaseWriteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.databaseWriteButton.Name = "databaseWriteButton";
            this.databaseWriteButton.Size = new System.Drawing.Size(99, 29);
            this.databaseWriteButton.TabIndex = 16;
            this.databaseWriteButton.Text = "Write to database";
            this.databaseWriteButton.UseVisualStyleBackColor = true;
            this.databaseWriteButton.Click += new System.EventHandler(this.writeToDatabaseButton_click);
            // 
            // eventsBox
            // 
            this.eventsBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.eventsBox.Location = new System.Drawing.Point(32, 282);
            this.eventsBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eventsBox.Multiline = true;
            this.eventsBox.Name = "eventsBox";
            this.eventsBox.Size = new System.Drawing.Size(385, 181);
            this.eventsBox.TabIndex = 17;
            // 
            // writeToDatabaseToolStripMenuItem
            // 
            this.writeToDatabaseToolStripMenuItem.Name = "writeToDatabaseToolStripMenuItem";
            this.writeToDatabaseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.writeToDatabaseToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.writeToDatabaseToolStripMenuItem.Text = "Write to database";
            this.writeToDatabaseToolStripMenuItem.Click += new System.EventHandler(this.writeToDatabaseButton_click);
            // 
            // queryDatabaseToolStripMenuItem
            // 
            this.queryDatabaseToolStripMenuItem.Name = "queryDatabaseToolStripMenuItem";
            this.queryDatabaseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.queryDatabaseToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.queryDatabaseToolStripMenuItem.Text = "Query database";
            this.queryDatabaseToolStripMenuItem.Click += new System.EventHandler(this.queryDatabaseButton_click);
            // 
            // clearDatabaseToolStripMenuItem
            // 
            this.clearDatabaseToolStripMenuItem.Name = "clearDatabaseToolStripMenuItem";
            this.clearDatabaseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clearDatabaseToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.clearDatabaseToolStripMenuItem.Text = "Clear database";
            this.clearDatabaseToolStripMenuItem.Click += new System.EventHandler(this.clearDatabaseButton_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 482);
            this.Controls.Add(this.eventsBox);
            this.Controls.Add(this.databaseWriteButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.databaseExtension);
            this.Controls.Add(this.extensionMonitor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.databaseClearButton);
            this.Controls.Add(this.databaseQuereButton);
            this.Controls.Add(this.databaseBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.directoryBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "File System Watcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileSystemWatcherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox directoryBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button databaseClearButton;
        private System.Windows.Forms.Button databaseQuereButton;
        private System.Windows.Forms.TextBox databaseBox;
        private System.Windows.Forms.ComboBox extensionMonitor;
        private System.Windows.Forms.ComboBox databaseExtension;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button databaseWriteButton;
        private System.Windows.Forms.TextBox eventsBox;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shortcutsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writeToDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDatabaseToolStripMenuItem;

    }
}

