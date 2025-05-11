using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Threading;
using System.Windows.Forms;

namespace Proiect1
{
    internal class SQLite
    {
        public static SQLiteConnection ConnectToDb()
        {
            SQLiteConnection conn = null;
            conn = new SQLiteConnection("Data Source=proiect1.db; Version = 3;");

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return conn;
        }

        public static void DisconnectFromDb(SQLiteConnection conn)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }

        public static void InsertKeyword(SQLiteConnection conn, string keyword)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                List<string> existakeyword = GetAllKeywords(conn);
                int count = (from existingKeyword in existakeyword
                             where existingKeyword.Equals(keyword, StringComparison.OrdinalIgnoreCase)
                             select existingKeyword).Count();

                if (count == 0)
                {
                    SQLiteCommand cmd;
                    cmd = conn.CreateCommand();
                    cmd.CommandText = "INSERT INTO ViewKeywords (keyword)" + "VALUES ('" + keyword + "')";
                    cmd.Parameters.AddWithValue("keyword", keyword);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Cuvantul cheie deja exista in baza de date!", "Grija mare - keyword duplicat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public static void DeleteKeyword(SQLiteConnection conn, string keyword)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                SQLiteCommand cmd;
                cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM ViewKeywords WHERE keyword = @keyword";
                cmd.Parameters.AddWithValue("@keyword", keyword);
                cmd.ExecuteNonQuery();
            }
        }

        public static List<string> GetAllKeywords(SQLiteConnection conn)
        {
            List<string> keywords = new List<string>();

            SQLiteDataReader reader;
            SQLiteCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT keyword FROM ViewKeywords";

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                keywords.Add(reader.GetString(0));
            }
            reader.Close();

            return keywords;
        }

    }

}
