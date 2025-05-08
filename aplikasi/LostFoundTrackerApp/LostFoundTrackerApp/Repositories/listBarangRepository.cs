using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using LostFoundTrackerApp.Helpers;

namespace LostFoundTrackerApp.Repositories
{
    public class listBarangRepository
    {
        private readonly DatabaseHelper dbHelper;

        public listBarangRepository()
        {
            dbHelper = new DatabaseHelper();
        }

        // Fungsi untuk mengambil semua barang
        public List<Dictionary<string, string>> GetAllBarang()
        {
            List<Dictionary<string, string>> barangList = new List<Dictionary<string, string>>();
            try
            {
                dbHelper.OpenConnection();
                string query = "SELECT id, item_name, description, location_found, founder, date_found FROM items";
                MySqlCommand cmd = new MySqlCommand(query, dbHelper.GetConnection());
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    // Ensure that values are not null before adding them to the dictionary
                    var barang = new Dictionary<string, string>
                    {
                        { "id", dr["id"]?.ToString() ?? "N/A" },
                        { "item_name", dr["item_name"]?.ToString() ?? "No Name" },
                        { "description", dr["description"]?.ToString() ?? "No Description" },
                        { "location_found", dr["location_found"]?.ToString() ?? "Unknown" },
                        { "founder", dr["founder"]?.ToString() ?? "Unknown" },
                        { "date_found", dr["date_found"]?.ToString() ?? "Unknown Date" }
                    };

                    barangList.Add(barang);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error while fetching data: " + ex.Message);
            }
            finally
            {
                dbHelper.CloseConnection();
            }
            return barangList;
        }

        // Fungsi untuk mencari barang berdasarkan nama
        public List<Dictionary<string, string>> SearchBarang(string searchInput)
        {
            List<Dictionary<string, string>> barangList = new List<Dictionary<string, string>>();
            try
            {
                if (string.IsNullOrWhiteSpace(searchInput))
                {
                    throw new ArgumentException("Search input cannot be empty.");
                }

                dbHelper.OpenConnection();
                string query = "SELECT id, item_name, description, location_found, founder, date_found FROM items WHERE item_name LIKE @search";
                MySqlCommand cmd = new MySqlCommand(query, dbHelper.GetConnection());
                cmd.Parameters.AddWithValue("@search", "%" + searchInput + "%");

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    // Ensure that values are not null before adding them to the dictionary
                    var barang = new Dictionary<string, string>
                    {
                        { "id", dr["id"]?.ToString() ?? "N/A" },
                        { "item_name", dr["item_name"]?.ToString() ?? "No Name" },
                        { "description", dr["description"]?.ToString() ?? "No Description" },
                        { "location_found", dr["location_found"]?.ToString() ?? "Unknown" },
                        { "founder", dr["founder"]?.ToString() ?? "Unknown" },
                        { "date_found", dr["date_found"]?.ToString() ?? "Unknown Date" }
                    };

                    barangList.Add(barang);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error while searching: " + ex.Message);
            }
            finally
            {
                dbHelper.CloseConnection();
            }
            return barangList;
        }
    }
}


