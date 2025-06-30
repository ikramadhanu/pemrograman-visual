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
    public partial class laporanHilang : UserControl
    {
        private LaporanHilangController controller;
        public laporanHilang()
        {
            InitializeComponent();
            controller = new LaporanHilangController();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Validasi form
            if (string.IsNullOrWhiteSpace(textName.Text) ||
                string.IsNullOrWhiteSpace(textDesc.Text) ||
                string.IsNullOrWhiteSpace(textLoc.Text) ||
                string.IsNullOrWhiteSpace(textAddress.Text))
            {
                MessageBox.Show("Peringatan : Form Harus Diisi", "LAPORAN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = controller.SimpanLaporan(
                textName.Text,
                textAddress.Text,
                textDesc.Text,
                dateTimePickerMissing.Value,
                textLoc.Text
            );

            if (success)
            {
                MessageBox.Show("Sukses : Data Berhasil Disimpan", "LAPORAN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textName.Clear();
                textDesc.Clear();
                textLoc.Clear();
                textAddress.Clear();
                dateTimePickerMissing.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Gagal : Data Gagal Disimpan", "LAPORAN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
