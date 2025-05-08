using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using LostFoundTrackerApp.Helpers;

namespace LostFoundTrackerApp.Repositories
{
    public class listKlaimRepository
    {
        private readonly DatabaseHelper dbHelper;

        public listKlaimRepository()
        {
            dbHelper = new DatabaseHelper();
        }

        // Fungsi untuk mengambil data klaim
        public List<Dictionary<string, string>> GetKlaimList()
        {
            List<Dictionary<string, string>> klaimList = new List<Dictionary<string, string>>();
            try
            {
                dbHelper.OpenConnection();
                string query = "SELECT id, claim_name, desc_bukti, claim_contact, claim_date FROM items WHERE claim_name IS NOT NULL AND claim_name != '';";
                MySqlCommand cmd = new MySqlCommand(query, dbHelper.GetConnection());
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    var klaim = new Dictionary<string, string>
                    {
                        { "id", dr["id"].ToString() ?? string.Empty },  // Menggunakan null-coalescing operator (??) untuk mengatasi null
                        { "claim_name", dr["claim_name"].ToString() ?? string.Empty },
                        { "desc_bukti", dr["desc_bukti"].ToString() ?? string.Empty },
                        { "claim_contact", dr["claim_contact"].ToString() ?? string.Empty },
                        { "claim_date", dr["claim_date"].ToString() ?? string.Empty }
                    };

                    klaimList.Add(klaim);
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
            return klaimList;
        }

        // Fungsi untuk menghapus klaim berdasarkan ID
        public bool DeleteKlaim(string id)
        {
            try
            {
                dbHelper.OpenConnection();
                string query = "DELETE FROM items WHERE id = @id";
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
