using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LostFoundTrackerApp.Repositories; // Mengimpor repository listKlaim

namespace LostFoundTrackerApp.UserControls
{
    public partial class listKlaim : UserControl
    {
        private listKlaimRepository listKlaimRepo;  // Instance dari repository listKlaim

        public listKlaim()
        {
            InitializeComponent();
            listKlaimRepo = new listKlaimRepository();  // Inisialisasi objek listKlaimRepository
        }

        // Fungsi untuk memuat data klaim
        public void loadRecord()
        {
            dataGridView1.Rows.Clear();

            try
            {
                var klaimList = listKlaimRepo.GetKlaimList(); // Ambil data klaim dari repository

                foreach (var klaim in klaimList)
                {
                    dataGridView1.Rows.Add(
                        dataGridView1.Rows.Count + 1,
                        klaim["id"],
                        klaim["claim_name"],
                        klaim["desc_bukti"],
                        klaim["claim_contact"],
                        klaim["claim_date"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal Memuat Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    bool success = listKlaimRepo.DeleteKlaim(deleteId); // Hapus klaim dengan repository

                    if (success)
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

