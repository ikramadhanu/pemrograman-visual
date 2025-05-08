using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LostFoundTrackerApp.Repositories; // Mengimpor repository listBarang

namespace LostFoundTrackerApp.UserControls
{
    public partial class listBarang : UserControl
    {
        private listBarangRepository listBarangRepo;  // Instance dari repository listBarang

        public listBarang()
        {
            InitializeComponent();
            listBarangRepo = new listBarangRepository();  // Inisialisasi objek listBarangRepository
        }

        // Fungsi untuk memuat semua data barang
        public void loadRecord()
        {
            dataGridView1.Rows.Clear();

            try
            {
                var barangList = listBarangRepo.GetAllBarang(); // Ambil data barang dari repository

                foreach (var barang in barangList)
                {
                    dataGridView1.Rows.Add(
                        dataGridView1.Rows.Count + 1,
                        barang["id"],
                        barang["item_name"],
                        barang["description"],
                        barang["location_found"],
                        barang["founder"],
                        barang["date_found"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBarang_Load(object sender, EventArgs e)
        {
            loadRecord();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadRecord();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string searchInput = textBoxSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchInput))
            {
                MessageBox.Show("Silakan masukkan kata kunci untuk pencarian.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var searchResults = listBarangRepo.SearchBarang(searchInput); // Cari barang dengan repository

                if (searchResults.Count > 0)
                {
                    foreach (var barang in searchResults)
                    {
                        dataGridView1.Rows.Add(
                            dataGridView1.Rows.Count + 1,
                            barang["id"],
                            barang["item_name"],
                            barang["description"],
                            barang["location_found"],
                            barang["founder"],
                            barang["date_found"]
                        );
                    }
                }
                else
                {
                    MessageBox.Show("Data tidak ditemukan untuk kata kunci: " + searchInput, "Hasil Pencarian", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            textBoxSearch.Clear();
        }
    }
}

