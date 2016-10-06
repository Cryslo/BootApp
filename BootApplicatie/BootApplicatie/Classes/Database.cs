using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BootApplicatie.Classes
{
    class Database : Form
    {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\BootappDB.MDF;Integrated Security=True";
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
        

        public void AddToDB(int nmbr, string name, string password)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Users (User_ID, Name, Password) VALUES (@UID, @Name, @Pw)");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@UID", nmbr);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Pw", password);

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
