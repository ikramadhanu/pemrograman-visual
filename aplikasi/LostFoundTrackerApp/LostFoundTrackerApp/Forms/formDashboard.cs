using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LostFoundTrackerApp.UserControls;

namespace LostFoundTrackerApp.Forms
{
    public partial class formDashboard : Form
    {
        public formDashboard()
        {
            InitializeComponent();
            dashboard1.BringToFront();
            labelTitle.Text = "Dashboard";
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
            dashboard1.BringToFront();
            labelTitle.Text = "Dashboard";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            inputBarang1.BringToFront();
            labelTitle.Text = "Input Barang";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            klaimBarang1.BringToFront();
            labelTitle.Text = "Klaim Barang";
        }

        private void klaimBarang1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            aboutUs1.BringToFront();
            labelTitle.Text = "About Us";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            listBarang1.BringToFront();
            labelTitle.Text = "List Barang Temuan";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            listKlaim1.BringToFront();
            labelTitle.Text = "Riwayat Klaim";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            laporanHilang1.BringToFront();
            labelTitle.Text = "Laporan Hilang";
        }

        private void label8_Click(object sender, EventArgs e)
        {
            listLaporan1.BringToFront();
            labelTitle.Text = "List Laporan";
        }
    }
}
