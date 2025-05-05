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
using LostFoundTrackerApp.Helpers;  // Mengimpor namespace Helpers

namespace LostFoundTrackerApp.UserControls
{
    public partial class listKlaim : UserControl
    {
        private DatabaseHelper dbHelper;  // Deklarasi objek DatabaseHelper
        private MySqlDataReader dr;
        public listKlaim()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();  // Membuat instance DatabaseHelper
        }

        public void loadRecord()
        {
            dataGridView1.Rows.Clear();
            try
            {
                dbHelper.OpenConnection();  // Membuka koneksi ke database

                string query = "SELECT id, claim_name, desc_bukti, claim_contact, claim_date FROM items WHERE claim_name IS NOT NULL AND claim_name != '';";
                MySqlCommand cmd = new MySqlCommand(query, dbHelper.GetConnection());  // Menggunakan koneksi dari dbHelper

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dr["id"].ToString(), dr["claim_name"].ToString(), dr["desc_bukti"].ToString(), dr["claim_contact"].ToString(), dr["claim_date"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal Memuat Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbHelper.CloseConnection();  // Menutup koneksi setelah operasi selesai
            }
        }

        private void listKlaim_Load(object sender, EventArgs e)
        {
            loadRecord();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            loadRecord();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string deleteId = textBoxDelete.Text.Trim();

            if (string.IsNullOrEmpty(deleteId))
            {
                MessageBox.Show("Silakan masukkan ID yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data dengan ID: " + deleteId + "?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    dbHelper.OpenConnection();  // Membuka koneksi ke database
                    string query = "DELETE FROM items WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, dbHelper.GetConnection());
                    cmd.Parameters.AddWithValue("@id", deleteId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    dbHelper.CloseConnection();  // Menutup koneksi setelah operasi selesai
                    textBoxDelete.Clear();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadRecord();
                    }
                    else
                    {
                        MessageBox.Show("Data dengan ID tersebut tidak ditemukan.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
