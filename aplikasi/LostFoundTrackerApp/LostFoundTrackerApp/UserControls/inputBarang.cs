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
    public partial class inputBarang : UserControl
    {
        string connstring = "server=localhost;uid=root;pwd=;database=lost_found_tracker";
        MySqlConnection conn;
        public inputBarang()
        {
            InitializeComponent();
            conn = new MySqlConnection(connstring);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if ((textName.Text == string.Empty) || (textDesc.Text == string.Empty) || (textLocation.Text == string.Empty) || (textFounder.Text == string.Empty))
            {
                MessageBox.Show("Peringatan : Form Harus Diisi", "BARANG", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                conn.Open();
                string query = "INSERT INTO items (item_name, description, location_found, founder, date_found) VALUES (@name, @description, @location, @founder, @date)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                string date = dateTimePickerFound.Value.ToString("yyyy-MM-dd");
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", textName.Text);
                cmd.Parameters.AddWithValue("@description", textDesc.Text);
                cmd.Parameters.AddWithValue("@location", textLocation.Text);
                cmd.Parameters.AddWithValue("@founder", textFounder.Text);
                cmd.Parameters.AddWithValue("@date", date);

                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Sukses : Data Berhasil Disimpan", "BARANG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textName.Clear();
                    textDesc.Clear();
                    textLocation.Clear();
                    textFounder.Clear();
                    dateTimePickerFound.Value = DateTime.Now;
                } else
                {
                    MessageBox.Show("Gagal : Data Gagal Disimpan", "BARANG", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                conn.Close();
            }
        }
    }
}
