using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using LostFoundTrackerApp.Helpers;

namespace LostFoundTrackerApp.Repositories
{
    public class listLaporanRepository
    {
        private readonly DatabaseHelper dbHelper;

        public listLaporanRepository()
        {
            dbHelper = new DatabaseHelper();
        }

        // Fungsi untuk mengambil data klaim
        public List<Dictionary<string, string>> GetLaporanList()
        {
            List<Dictionary<string, string>> laporanList = new List<Dictionary<string, string>>();
            try
            {
                dbHelper.OpenConnection();
                string query = "SELECT id, name, address, description, date, loc FROM report WHERE name IS NOT NULL AND name != '';";
                MySqlCommand cmd = new MySqlCommand(query, dbHelper.GetConnection());
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    var laporan = new Dictionary<string, string>
                    {
                        { "id", dr["id"].ToString() ?? string.Empty },  // Menggunakan null-coalescing operator (??) untuk mengatasi null
                        { "name", dr["name"].ToString() ?? string.Empty },
                        { "address", dr["address"].ToString() ?? string.Empty },
                        { "description", dr["description"].ToString() ?? string.Empty },
                        { "date", dr["date"].ToString() ?? string.Empty },
                        { "loc", dr["loc"].ToString() ?? string.Empty }
                    };

                    laporanList.Add(laporan);
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
            return laporanList;
        }

        // Fungsi untuk menghapus klaim berdasarkan ID
        public bool DeleteLaporan(string id)
        {
            try
            {
                dbHelper.OpenConnection();
                string query = "DELETE FROM report WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, dbHelper.GetConnection());
                cmd.Parameters.AddWithValue("@id", id);

                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error while deleting data: " + ex.Message);
            }
            finally
            {
                dbHelper.CloseConnection();
            }
        }
    }
}
