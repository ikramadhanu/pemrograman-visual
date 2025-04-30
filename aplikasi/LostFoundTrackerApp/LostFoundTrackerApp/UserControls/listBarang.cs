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
    public partial class listBarang : UserControl
    {
        string connstring = "server=localhost;uid=root;pwd=;database=lost_found_tracker";
        MySqlConnection conn;
        MySqlDataReader dr;

        public listBarang()
        {
            InitializeComponent();
            conn = new MySqlConnection(connstring);
        }

        public void loadRecord()
        {
            dataGridView1.Rows.Clear();
            conn.Open();
            string query = "SELECT * FROM items";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dr["id"].ToString(), dr["item_name"].ToString(), dr["description"].ToString(), dr["location_found"].ToString(), dr["founder"].ToString(), dr["date_found"].ToString());
            }
            dr.Close();
            conn.Close();
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

            conn.Open();
            string query = "SELECT * FROM items WHERE item_name LIKE @search";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@search", "%" + searchInput + "%");

            dr = cmd.ExecuteReader();

            bool hasData = false;

            while (dr.Read())
            {
                hasData = true;
                dataGridView1.Rows.Add(
                    dataGridView1.Rows.Count + 1,
                    dr["id"].ToString(),
                    dr["item_name"].ToString(),
                    dr["description"].ToString(),
                    dr["location_found"].ToString(),
                    dr["founder"].ToString(),
                    dr["date_found"].ToString()
                );
            }

            dr.Close();
            conn.Close();

            if (!hasData)
            {
                MessageBox.Show("Data tidak ditemukan untuk kata kunci: " + searchInput, "Hasil Pencarian", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
