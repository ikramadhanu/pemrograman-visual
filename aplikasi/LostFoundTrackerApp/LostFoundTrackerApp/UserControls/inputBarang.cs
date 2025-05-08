using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LostFoundTrackerApp.Repositories; // Mengimpor repository inputBarang

namespace LostFoundTrackerApp.UserControls
{
    public partial class inputBarang : UserControl
    {
        private inputBarangRepository inputBarangRepo;  // Instance dari repository inputBarang

        public inputBarang()
        {
            InitializeComponent();
            inputBarangRepo = new inputBarangRepository();  // Inisialisasi objek inputBarangRepository
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Validasi form
            if (string.IsNullOrWhiteSpace(textName.Text) ||
                string.IsNullOrWhiteSpace(textDesc.Text) ||
                string.IsNullOrWhiteSpace(textLocation.Text) ||
                string.IsNullOrWhiteSpace(textFounder.Text))
            {
                MessageBox.Show("Peringatan : Form Harus Diisi", "BARANG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Panggil repository untuk menyimpan data
            bool success = inputBarangRepo.InsertBarang(
                textName.Text,
                textDesc.Text,
                textLocation.Text,
                textFounder.Text,
                dateTimePickerFound.Value
            );

            // Menampilkan pesan hasil
            if (success)
            {
                MessageBox.Show("Sukses : Data Berhasil Disimpan", "BARANG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textName.Clear();
                textDesc.Clear();
                textLocation.Clear();
                textFounder.Clear();
                dateTimePickerFound.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Gagal : Data Gagal Disimpan", "BARANG", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

