using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SystemFileWatcherGUI
{
    public partial class QueryForm : Form
    {
        private SQLiteConnection sqlite_conn;
        public SQLiteConnection Connection { get { return this.sqlite_conn; } set { this.sqlite_conn = value; } }
        private SQLiteCommand sqlite_cmd;
        public SQLiteCommand Command { get { return this.sqlite_cmd; } set { this.sqlite_cmd = value; } }
        private SQLiteDataReader sqlite_datareader;
        public SQLiteDataReader Reader { get { return this.sqlite_datareader; } set { this.sqlite_datareader = value; } }
        private String extensionFilter;

        public QueryForm(SQLiteConnection conn, String extensionFilter)
        {
            InitializeComponent();
            this.sqlite_conn = conn;
            this.extensionFilter = extensionFilter;
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            Command = Connection.CreateCommand();
 
            if(extensionFilter == "")
            {
                Command.CommandText = "SELECT * FROM WatchedFiles";
                
            }
            else
            {
                Command.CommandText = "SELECT * FROM WatchedFiles WHERE Extension='" + extensionFilter + "'";
            }
            Reader = Command.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(Reader);
            QueryView.DataSource = table.DefaultView;

            QueryView.Columns[3].HeaderText = "Date and Time";
            for (int i = 0; i < QueryView.ColumnCount; i++)
                QueryView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
        }
    }
}
