using DocumentFormat.OpenXml.Drawing.ChartDrawing;
using OpenXmlPowerTools;
using SolrNet.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Diagnostics;

namespace Proiect1
{
    public partial class Form1 : Form
    {
        private SQLiteConnection conn;

        private List<string> lstBlock = new List<string>();

        //{
        //    "sport", "tiktok", "netflix"
        //};

        public Form1()
        {
            InitializeComponent();
            FileStream file = new FileStream("log.txt", FileMode.OpenOrCreate, FileAccess.Write);
            TextWriterTraceListener textWriterTraceListener = new TextWriterTraceListener(file);
            Trace.Listeners.Add(textWriterTraceListener);
            Trace.AutoFlush = true;

            SQLiteConnection conn = SQLite.ConnectToDb();
            lstBlock = SQLite.GetAllKeywords(conn);

            conectareToolStripMenuItem_Click();
        }
        private void conectareToolStripMenuItem_Click()
        {
            conn = SQLite.ConnectToDb();
            //if (conn != null && conn.State == System.Data.ConnectionState.Open)
        }
        private void adaugare(string keyword)
        {
            if (conn == null || conn.State != System.Data.ConnectionState.Open)
            {
                return;
            }
            if (!string.IsNullOrEmpty(keyword))
            {
                SQLite.InsertKeyword(conn, keyword);
                MessageBox.Show($"Cuvantul cheie '{keyword}' a fost adaugat cu succes.", "Adaugare cuvant cheie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Eroare, incearca din nou.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void toolStripGOBtn_Click(object sender, EventArgs e)
        {
            String url = this.toolStripTextBox1.Text;
            await AsyncLogIn($"Navigare catre: {url}");
            webBrowser1.Navigate(url);

        }
        private async void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String url = this.toolStripTextBox1.Text;
                await AsyncLogIn($"Navigare catre: {url}");
                webBrowser1.Navigate(url);
            }

        }
        private async void toolStripBackBtn_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                await AsyncLogIn("Navigare inapoi.");
                webBrowser1.GoBack();
            }
            else
            {
                MessageBox.Show("Nu este pagina anterioara.");
            }

        }
        private async void toolStripForwardBtn_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward) 
            {
                await AsyncLogIn("Navigare inainte.");
                webBrowser1.GoForward();
            }
            else
            {
                MessageBox.Show("Nu este pagina urmatoare.");
            }
        }
        private async void toolStripHomeBtn_Click(object sender, EventArgs e)
        {
            await AsyncLogIn("Navigare home.");
            webBrowser1.GoHome();
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
        private void toolStripCBKeywords_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = SQLite.ConnectToDb();
            toolStripCBKeywords.Items.Clear();
            List<string> keywords = SQLite.GetAllKeywords(conn);
            foreach (string keyword in keywords)
            {
                toolStripCBKeywords.Items.Add(keyword);
            }
        }
        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            string url = e.Url.ToString();
            //    foreach (string item in lstBlock)
            //    {
            //        if (url.Contains(item))
            //        {
            //            e.Cancel = true;
            //            MessageBox.Show("Url blocat ( " + item + ")");
            //            break;
            //        }
            //    }
            //expresie lamda
            //bool found = false;
            //found = lstBlock.Any(x => url.Contains(x));
            //    if (found)
            //    {
            //        e.Cancel = true;
            //        MessageBox.Show("URL blocat.");
            //    }
            //LINQ
            //    int count;
            //    count = (from x in lstBlock
            //             where url.Contains(x)
            //             select x).Count();
            var res = Task.Run(() => AsyncCheckUrl(url));

            res.Wait();

            if (res.Result == true)
            {
                e.Cancel = true;
                MessageBox.Show("URL blocat.", "Blocare URL", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private async Task<bool> AsyncCheckUrl(string url)
        {
            bool res = await Task.Run(() =>
            {
                return (from x in lstBlock
                        where url.Contains(x)
                        select x).Count() > 0;
            });
            return res;

        }
        private async Task AsyncLogIn(string message) 
        {
            await Task.Run(() => 
            {
                    string loginmessage = $"{DateTime.Now:dd-MM-yyyy hh:mm:ss.fff} - {message}";
                    Trace.WriteLine(loginmessage);
                    Trace.Flush();
            });
        }
        private void addKeywordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeywordInput kwdForm = new KeywordInput();
            kwdForm.ShowDialog();
            SQLiteConnection conn = SQLite.ConnectToDb();
            lstBlock = SQLite.GetAllKeywords(conn);
        }
        private void deleteKeywordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeywordDelete deletekeyword = new KeywordDelete();
            deletekeyword.ShowDialog();
        }
        private void viewKeywordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewKeywords viewKeywordsForm = new ViewKeywords();
            viewKeywordsForm.ShowDialog();   
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (conn != null && conn.State == ConnectionState.Open)
            {
                SQLite.DisconnectFromDb(conn);
                conn = null;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bun venit! Acesta este primul proiect!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
