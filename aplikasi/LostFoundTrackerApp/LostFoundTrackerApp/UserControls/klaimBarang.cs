using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LostFoundTrackerApp.Repositories; // pakai klaimBarangRepository

namespace LostFoundTrackerApp.UserControls
{
    public partial class klaimBarang : UserControl
    {
        private klaimBarangRepository klaimRepo;

        public klaimBarang()
        {
            InitializeComponent();
            klaimRepo = new klaimBarangRepository();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textID.Text) ||
                string.IsNullOrWhiteSpace(textDescBukti.Text) ||
                string.IsNullOrWhiteSpace(textClaimName.Text) ||
                string.IsNullOrWhiteSpace(textClaimContact.Text))
            {
                MessageBox.Show("Peringatan : Form Harus Diisi", "KLAIM BARANG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = klaimRepo.UpdateKlaimBarang(
                textID.Text,
                textDescBukti.Text,
                textClaimContact.Text,
                textClaimName.Text,
                dateTimeClaim.Value
            );

            if (success)
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
        }
    }
}

