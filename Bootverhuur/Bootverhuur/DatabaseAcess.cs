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

        public DataTable GetVerhuurders(string table)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlconn = new SqlConnection(connectionString);
            sqlconn.Open();
            string query = "SELECT * FROM " + table;
            SqlCommand cmd = new SqlCommand(query, sqlconn);

            dt.Columns.AddRange(new DataColumn[]{
            new DataColumn("ContractID", typeof(Int32)),
            new DataColumn("Naam", typeof(string)),
            new DataColumn("Email", typeof(string)),
            new DataColumn("Verhuurder", typeof(string)),
            new DataColumn("Boot", typeof(string)),
            new DataColumn("Artikelen", typeof(string)),
            new DataColumn("DatumStart", typeof(string)),
            new DataColumn("DatumEind", typeof(string))
            });

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    DataRow newRow = dt.NewRow();
                    newRow["ContractID"] = reader.GetInt32(0);
                    newRow["Naam"] = reader.GetString(1);
                    newRow["Email"] = reader.GetString(2);
                    newRow["Verhuurder"] = reader.GetString(3);
                    newRow["Boot"] = reader.GetString(4);
                    newRow["Artikelen"] = reader.GetString(5);
                    newRow["DatumStart"] = reader.GetString(6);
                    newRow["DatumEind"] = reader.GetString(7);
                    dt.Rows.Add(newRow);
                }
                sqlconn.Close();
            }

            return dt;
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
        public void Add_HuurderToDB(string ID, string naam, string email, string verhuurder, string boot, string artikelen, string datumstart, string datumeind)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO HuurContracten (ContractID, Naam, Email, Verhuurder, Boot, Artikelen, DatumStart, DatumEind) VALUES (@CID, @NAAM, @EMAIL, @VHD, @BOOT, @ART, @DTS, @DTE)");
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            try
            {
                cmd.Parameters.AddWithValue("@CID", ID);
                cmd.Parameters.AddWithValue("@NAAM", naam);
                cmd.Parameters.AddWithValue("@EMAIL", email);
                cmd.Parameters.AddWithValue("@VHD", verhuurder);
                cmd.Parameters.AddWithValue("@BOOT", boot);
                cmd.Parameters.AddWithValue("@ART", artikelen);
                cmd.Parameters.AddWithValue("@DTS", datumstart);
                cmd.Parameters.AddWithValue("@DTE", datumeind);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception a)
            {
                conn.Close();
                MessageBox.Show(a.Message);
            }
        }

    }
}
