using System.Linq.Expressions;
using LostFoundTrackerApp.Forms;
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Connect Database
            string connstring = "server=localhost;uid=root;pwd=;database=lost_found_tracker";
            MySqlConnection conn = new MySqlConnection(connstring);

            string username = this.username.Text;
            string password = this.password.Text;

            try
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM admin WHERE username=@username AND password=@password";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    formDashboard obj = new formDashboard();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
