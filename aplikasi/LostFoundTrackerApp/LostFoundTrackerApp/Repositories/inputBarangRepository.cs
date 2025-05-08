using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using LostFoundTrackerApp.Helpers;

namespace LostFoundTrackerApp.Repositories
{
    public class inputBarangRepository
    {
        private readonly DatabaseHelper dbHelper;

        public inputBarangRepository()
        {
            dbHelper = new DatabaseHelper();
        }

        public bool InsertBarang(string name, string description, string location, string founder, DateTime dateFound)
        {
            try
            {
                dbHelper.OpenConnection();

                string query = "INSERT INTO items (item_name, description, location_found, founder, date_found) VALUES (@name, @description, @location, @founder, @date)";
                MySqlCommand cmd = new MySqlCommand(query, dbHelper.GetConnection());

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@location", location);
                cmd.Parameters.AddWithValue("@founder", founder);
                cmd.Parameters.AddWithValue("@date", dateFound.ToString("yyyy-MM-dd"));

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
