namespace SystemFileWatcherGUI
{
    partial class Form1
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
            this.databaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shortcutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.Size = new System.Drawing.Size(595, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitButton_click);
            // 
            // fileSystemWatcherToolStripMenuItem
            // 
            this.fileSystemWatcherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.fileSystemWatcherToolStripMenuItem.Name = "fileSystemWatcherToolStripMenuItem";
            this.fileSystemWatcherToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.fileSystemWatcherToolStripMenuItem.Text = "FileSystemWatcher";
            // 
            // databaseToolStripMenuItem
            // 
            this.databaseToolStripMenuItem.Name = "databaseToolStripMenuItem";
            this.databaseToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.databaseToolStripMenuItem.Text = "Database";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.CheckOnClick = true;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shortcutsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.aboutButton_click);
            // 
            // directoryBox
            // 
            this.directoryBox.Location = new System.Drawing.Point(260, 104);
            this.directoryBox.Name = "directoryBox";
            this.directoryBox.Size = new System.Drawing.Size(294, 22);
            this.directoryBox.TabIndex = 1;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(260, 132);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 30);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(454, 132);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(100, 30);
            this.stopButton.TabIndex = 3;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Directory to monitor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Database";
            this.label2.Click += new System.EventHandler(this.stopButton_click);
            // 
            // databaseClearButton
            // 
            this.databaseClearButton.Location = new System.Drawing.Point(479, 274);
            this.databaseClearButton.Name = "databaseClearButton";
            this.databaseClearButton.Size = new System.Drawing.Size(75, 36);
            this.databaseClearButton.TabIndex = 7;
            this.databaseClearButton.Text = "Clear";
            this.databaseClearButton.UseVisualStyleBackColor = true;
            this.databaseClearButton.Click += new System.EventHandler(this.clearDatabaseButton_click);
            // 
            // databaseQuereButton
            // 
            this.databaseQuereButton.Location = new System.Drawing.Point(398, 274);
            this.databaseQuereButton.Name = "databaseQuereButton";
            this.databaseQuereButton.Size = new System.Drawing.Size(75, 36);
            this.databaseQuereButton.TabIndex = 6;
            this.databaseQuereButton.Text = "Query";
            this.databaseQuereButton.UseVisualStyleBackColor = true;
            this.databaseQuereButton.Click += new System.EventHandler(this.queryDatabaseButton_click);
            // 
            // databaseBox
            // 
            this.databaseBox.Location = new System.Drawing.Point(260, 246);
            this.databaseBox.Name = "databaseBox";
            this.databaseBox.Size = new System.Drawing.Size(294, 22);
            this.databaseBox.TabIndex = 5;
            // 
            // extensionMonitor
            // 
            this.extensionMonitor.FormattingEnabled = true;
            this.extensionMonitor.Items.AddRange(new object[] {
            ".txt",
            ".doc",
            ".wmv",
            ".ini"});
            this.extensionMonitor.Location = new System.Drawing.Point(42, 102);
            this.extensionMonitor.Name = "extensionMonitor";
            this.extensionMonitor.Size = new System.Drawing.Size(133, 24);
            this.extensionMonitor.TabIndex = 10;
            // 
            // databaseExtension
            // 
            this.databaseExtension.FormattingEnabled = true;
            this.databaseExtension.Items.AddRange(new object[] {
            ".txt",
            ".doc",
            ".wmv",
            ".ini"});
            this.databaseExtension.Location = new System.Drawing.Point(42, 246);
            this.databaseExtension.Name = "databaseExtension";
            this.databaseExtension.Size = new System.Drawing.Size(133, 24);
            this.databaseExtension.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Extension to monitor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Query or write by extension";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 327);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "File System Watcher Events";
            // 
            // databaseWriteButton
            // 
            this.databaseWriteButton.Location = new System.Drawing.Point(260, 274);
            this.databaseWriteButton.Name = "databaseWriteButton";
            this.databaseWriteButton.Size = new System.Drawing.Size(132, 36);
            this.databaseWriteButton.TabIndex = 16;
            this.databaseWriteButton.Text = "Write to database";
            this.databaseWriteButton.UseVisualStyleBackColor = true;
            this.databaseWriteButton.Click += new System.EventHandler(this.writeToDatabaseButton_click);
            // 
            // eventsBox
            // 
            this.eventsBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.eventsBox.Location = new System.Drawing.Point(42, 347);
            this.eventsBox.Multiline = true;
            this.eventsBox.Name = "eventsBox";
            this.eventsBox.Size = new System.Drawing.Size(512, 222);
            this.eventsBox.TabIndex = 17;
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.startToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startButton_click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopButton_click);
            // 
            // shortcutsToolStripMenuItem
            // 
            this.shortcutsToolStripMenuItem.Name = "shortcutsToolStripMenuItem";
            this.shortcutsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.shortcutsToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.shortcutsToolStripMenuItem.Text = "Shortcuts";
            this.shortcutsToolStripMenuItem.Click += new System.EventHandler(this.shortcutsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 593);
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

    }
}

