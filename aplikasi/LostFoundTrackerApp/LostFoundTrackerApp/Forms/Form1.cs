using System;
using System.Windows.Forms;
using LostFoundTrackerApp.Forms;
using MySql.Data.MySqlClient;
using LostFoundTrackerApp.Helpers;

namespace LostFoundTrackerApp
{
    public partial class Form1 : Form
    {
        // Publisher untuk event login
        private LoginEventPublisher publisher;
        private LoginEventSubscriber subscriber;
        private DatabaseHelper dbHelper;

        public Form1()
        {
            InitializeComponent();
            dbHelper = new DatabaseHelper();  // Inisialisasi DatabaseHelper
            publisher = new LoginEventPublisher();
            subscriber = new LoginEventSubscriber(this);
            publisher.OnLoginAttempt += subscriber.OnLoginReceived;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Cek koneksi database saat form dimuat
                dbHelper.OpenConnection();  // Membuka koneksi ke database
                MessageBox.Show("Koneksi ke database berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Jika koneksi gagal
                MessageBox.Show("Koneksi ke database gagal: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit(); // Menutup aplikasi jika koneksi gagal
            }
            finally
            {
                dbHelper.CloseConnection();  // Menutup koneksi setelah pengecekan selesai
            }
        }

        private void closeLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.username.Text;
            string password = this.password.Text;

            // Publisher menerbitkan event
            publisher.AttemptLogin(username, password);
        }
    }

    public class LoginEventPublisher
    {
        // Event untuk memberitahukan status login
        public event Action<string, bool> OnLoginAttempt = delegate { }; // Inisialisasi dengan event kosong
        private DatabaseHelper dbHelper;

        public LoginEventPublisher()
        {
            dbHelper = new DatabaseHelper(); // Menggunakan kelas DatabaseHelper untuk koneksi
        }

        public void AttemptLogin(string username, string password)
        {
            bool isSuccess = CheckLogin(username, password);
            OnLoginAttempt?.Invoke(username, isSuccess);
        }

        private bool CheckLogin(string username, string password)
        {
            try
            {
                dbHelper.OpenConnection();
                string query = "SELECT COUNT(*) FROM admin WHERE username=@username AND password=@password";
                MySqlCommand cmd = new MySqlCommand(query, dbHelper.GetConnection());
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                dbHelper.CloseConnection(); // Pastikan koneksi selalu ditutup setelah penggunaan
            }
        }
    }

    public class LoginEventSubscriber
    {
        private Form1 formLogin; // Tambahkan referensi ke form login

        public LoginEventSubscriber(Form1 form)
        {
            this.formLogin = form;
        }

        public void OnLoginReceived(string username, bool isSuccess)
        {
            if (isSuccess)
            {
                MessageBox.Show($"Login berhasil untuk user: {username}", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                formDashboard dashboard = new formDashboard();
                dashboard.Show();
                formLogin.Hide(); // Hide form login setelah dashboard tampil
            }
            else
            {
                MessageBox.Show($"Login gagal untuk user: {username}", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}