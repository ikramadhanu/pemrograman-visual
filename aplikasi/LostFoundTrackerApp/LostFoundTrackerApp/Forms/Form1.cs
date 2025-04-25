using System.Linq.Expressions;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;

namespace LostFoundTrackerApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Connect Database
            string connstring = "server=localhost;uid=root;pwd=;database=lost_found_tracker";
            MySqlConnection conn = new MySqlConnection(connstring);

            try
            {
                conn.Open();
                MessageBox.Show("KONEKSI BERHASIL", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void closeLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
