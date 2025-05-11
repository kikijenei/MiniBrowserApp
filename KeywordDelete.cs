using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class KeywordDelete : Form
    {
        public KeywordDelete()
        {
            InitializeComponent();
            LoadComboBox();

        }

        private void LoadComboBox()
        {
            SQLiteConnection conn = SQLite.ConnectToDb();
            comboBoxKeywordDelete.Items.Clear();
            List<string> keywords = SQLite.GetAllKeywords(conn);
            foreach (string keyword in keywords)
            {
                comboBoxKeywordDelete.Items.Add(keyword);
            }
        }
        private void comboBoxKeywordDelete_SelectedIndexChanged(object sender, EventArgs e)
        {   
        
        }

        private void BtnDeleteKeyword_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = SQLite.ConnectToDb();
            string keyword = comboBoxKeywordDelete.SelectedItem.ToString();
            SQLite.DeleteKeyword(conn, keyword);
            MessageBox.Show($"Cuvantul cheie '{keyword}' a fost sters cu succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadComboBox();

        }
    }
}
