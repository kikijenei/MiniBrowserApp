using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect1
{
    public partial class KeywordInput : Form
    {
        public KeywordInput()
        {
            InitializeComponent();
        }

        public string getInputText() 
        {
            return textBoxKeywordInput.Text;
        }

        private void btnCancelKeywordInput_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnOKKeywordInput_Click(object sender, EventArgs e)
        { 
            SQLiteConnection conn = SQLite.ConnectToDb();
            SQLite.InsertKeyword(conn, getInputText());
            this.Close();
        }
        private void textBoxKeywordInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SQLiteConnection conn = SQLite.ConnectToDb();
                SQLite.InsertKeyword(conn, getInputText());
                this.Close();
            }
        }
    }
}
