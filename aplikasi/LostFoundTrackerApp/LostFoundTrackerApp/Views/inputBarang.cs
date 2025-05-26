using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using LostFoundTrackerApp.Controllers;

namespace LostFoundTrackerApp.UserControls
{
    public partial class inputBarang : UserControl
    {
        private InputBarangController controller;

        public inputBarang()
        {
            InitializeComponent();
            controller = new InputBarangController();
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

            bool success = controller.SimpanBarang(
                textName.Text,
                textDesc.Text,
                textLocation.Text,
                textFounder.Text,
                dateTimePickerFound.Value
            );

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
