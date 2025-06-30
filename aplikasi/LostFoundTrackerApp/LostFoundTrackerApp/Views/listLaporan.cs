using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LostFoundTrackerApp.Controllers;

namespace LostFoundTrackerApp.Views
{
    public partial class listLaporan : UserControl
    {
        private ListLaporanController controller;
        public listLaporan()
        {
            InitializeComponent();
            controller = new ListLaporanController();
        }

        public void loadRecord()
        {
            dataGridView1.Rows.Clear();

            try
            {
                List<Dictionary<string, string>> klaimList = controller.AmbilSemuaLaporan();

                foreach (var klaim in klaimList)
                {
                    dataGridView1.Rows.Add(
                        dataGridView1.Rows.Count + 1,
                        klaim["id"],
                        klaim["name"],
                        klaim["address"],
                        klaim["description"],
                        klaim["date"],
                        klaim["loc"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Gagal Memuat Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listLaporan_Load(object sender, EventArgs e)
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
                    bool success = controller.HapusLaporan(deleteId);

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
