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
    public partial class listKlaim : UserControl
    {
        string connstring = "server=localhost;uid=root;pwd=;database=lost_found_tracker";
        MySqlConnection conn;
        MySqlDataReader dr;
        public listKlaim()
        {
            InitializeComponent();
            conn = new MySqlConnection(connstring);
        }

        public void loadRecord()
        {
            dataGridView1.Rows.Clear();
            conn.Open();
            string query = "SELECT id, claim_name, desc_bukti, claim_contact, claim_date FROM items WHERE claim_name IS NOT NULL AND claim_name != '';";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dr["id"].ToString(), dr["claim_name"].ToString(), dr["desc_bukti"].ToString(), dr["claim_contact"].ToString(), dr["claim_date"].ToString());
            }
            dr.Close();
            conn.Close();
        }

        private void listKlaim_Load(object sender, EventArgs e)
        {
            loadRecord();
        }
    }
}
