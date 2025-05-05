using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LostFoundTrackerApp.Helpers
{
    public class DatabaseHelper
    {
        private string connstring = "server=localhost;uid=root;pwd=;database=lost_found_tracker";
        private MySqlConnection conn;

        public DatabaseHelper()
        {
            conn = new MySqlConnection(connstring);
        }

        // Membuka koneksi ke database
        public void OpenConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        // Menutup koneksi database
        public void CloseConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        // Mendapatkan objek koneksi
        public MySqlConnection GetConnection()
        {
            return conn;
        }
    }
}
