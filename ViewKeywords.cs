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
    public partial class ViewKeywords : Form
    {
        public ViewKeywords()
        {
            InitializeComponent();
            LoadKeywords();
        }

        private void CloseBtnViewKeywords_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void LoadKeywords() 
        {
            SQLiteConnection conn = SQLite.ConnectToDb();
            List<string> keywords = SQLite.GetAllKeywords(conn);
            listViewKeywords.Items.Clear();
            foreach (string keyword in keywords) 
            {
                listViewKeywords.Items.Add(keyword);
            }
        }
    }
}
