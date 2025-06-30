using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using LostFoundTrackerApp.Helpers;

namespace LostFoundTrackerApp.Repositories
{
    public class laporanHilangRepository
    {
        private readonly DatabaseHelper dbHelper;

        public laporanHilangRepository()
        {
            dbHelper = new DatabaseHelper();
        }

        public bool InsertLaporan(string name, string address, string description, DateTime dateFound, string location)
        {
            try
            {
                dbHelper.OpenConnection();

                string query = "INSERT INTO report (name, address, description, date, loc) VALUES (@name, @address, @description, @date, @location)";
                MySqlCommand cmd = new MySqlCommand(query, dbHelper.GetConnection());

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@date", dateFound.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@location", location);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                dbHelper.CloseConnection();
            }
        }
    }
}
