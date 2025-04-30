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

namespace LostFoundTrackerApp.UserControls
{
    public partial class klaimBarang : UserControl
    {
        string connstring = "server=localhost;uid=root;pwd=;database=lost_found_tracker";
        MySqlConnection conn;
        public klaimBarang()
        {
            InitializeComponent();
            conn = new MySqlConnection(connstring);
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
                conn.Open();
                string query = "UPDATE items SET desc_bukti = @descbukti, claim_contact = @claimcontact, claim_name = @claimname, claim_date = @claimdate WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
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

                conn.Close();
            }
        }
    }
}
