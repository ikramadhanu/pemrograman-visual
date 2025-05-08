using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using LostFoundTrackerApp.Helpers;

namespace LostFoundTrackerApp.Repositories
{
    public class klaimBarangRepository
    {
        private readonly DatabaseHelper dbHelper;

        public klaimBarangRepository()
        {
            dbHelper = new DatabaseHelper();
        }

        public bool UpdateKlaimBarang(string id, string descBukti, string claimContact, string claimName, DateTime claimDate)
        {
            try
            {
                dbHelper.OpenConnection();

                string query = "UPDATE items SET desc_bukti = @descbukti, claim_contact = @claimcontact, claim_name = @claimname, claim_date = @claimdate WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, dbHelper.GetConnection());

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@descbukti", descBukti);
                cmd.Parameters.AddWithValue("@claimcontact", claimContact);
                cmd.Parameters.AddWithValue("@claimname", claimName);
                cmd.Parameters.AddWithValue("@claimdate", claimDate.ToString("yyyy-MM-dd"));

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
