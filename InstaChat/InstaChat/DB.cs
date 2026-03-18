using MySql.Data.MySqlClient;
using System.Data;

namespace InstaChat
{
    internal class DB
    {
        public static MySqlConnection Connect()
        {
            string server = "localhost";
            string database = "instachat";
            string username = "root";
            string password = "";
            string port = "3306";
            MySqlConnection conn = new MySqlConnection();
            try
            {
                conn = new MySqlConnection($"server={server};database={database};username={username};password={password};port={port}");
                conn.Open();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Close();
                    MessageBox.Show("Failed to connect to database");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            return conn;
        }
    }
}
