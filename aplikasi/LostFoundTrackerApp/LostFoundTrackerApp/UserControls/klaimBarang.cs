using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using LostFoundTrackerApp.Helpers; // Mengimpor namespace Helpers

namespace LostFoundTrackerApp.UserControls
{
    public partial class klaimBarang : UserControl
    {
        private DatabaseHelper dbHelper; // Deklarasi objek DatabaseHelper
        public klaimBarang()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper(); // Membuat instance DatabaseHelper
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textID.Text == string.Empty) || (textDescBukti.Text == string.Empty) || (textClaimName.Text == string.Empty) || (textClaimContact.Text == string.Empty))
            {
                MessageBox.Show("Peringatan : Form Harus Diisi", "KLAIM BARANG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                dbHelper.OpenConnection();
                string query = "UPDATE items SET desc_bukti = @descbukti, claim_contact = @claimcontact, claim_name = @claimname, claim_date = @claimdate WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, dbHelper.GetConnection());
                string date = dateTimeClaim.Value.ToString("yyyy-MM-dd");

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", textID.Text);
                cmd.Parameters.AddWithValue("@descbukti", textDescBukti.Text);
                cmd.Parameters.AddWithValue("@claimcontact", textClaimContact.Text);
                cmd.Parameters.AddWithValue("@claimname", textClaimName.Text);
                cmd.Parameters.AddWithValue("@claimdate", date);

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Sukses : Data Berhasil Disimpan", "KLAIM BARANG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textID.Clear();
                    textDescBukti.Clear();
                    textClaimName.Clear();
                    textClaimContact.Clear();
                    dateTimeClaim.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Gagal : Data Gagal Disimpan", "KLAIM BARANG", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                dbHelper.CloseConnection();
            }
        }
    }
}
