using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bootverhuur
{
    class DatabaseAcess
    {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\BotenverhuurDB.MDF;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connectionString);

        public List<string> Columnrequest(string column, string table)
        {
            try
            {
                List<string> info = new List<string>();
                SqlConnection sqlconn = new SqlConnection(connectionString);
                sqlconn.Open();
                string query = "SELECT " + column + " FROM " + table;
                SqlCommand cmd = new SqlCommand(query, sqlconn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        info.Add(Convert.ToString(reader[column]));
                    }
                    sqlconn.Close();
                    return info;
                }
            }
            catch (Exception a)
            {
                return null;
            }
        }
        public string RowRequest(string column, string table, string Name)
        {
            try
            {
                string info = "";
                SqlConnection sqlconn = new SqlConnection(connectionString);
                sqlconn.Open();
                string query = "SELECT " + column + " FROM " + table + " WHERE Name = '" + Name + "'";
                SqlCommand cmd = new SqlCommand(query, sqlconn);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        info = Convert.ToString(reader[column]);
                    }
                    sqlconn.Close();
                    return info;
                }
            }
            catch (Exception a)
            {
                return null;
            }
        }

        public void Add_BoatToDB(string ID, string Artikel)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Artikelen (ArtikelID, Artikel) VALUES (@AID, @ART)");
                
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@AID", ID);
                cmd.Parameters.AddWithValue("@ART", Artikel);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception a)
            {

            }
        }

    }
}
