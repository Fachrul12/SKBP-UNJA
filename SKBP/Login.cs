using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using MySqlX.XDevAPI;


namespace SKBP
{

    public partial class Login : Form
    {
        String conString = "server=localhost;database=db_skbp;uid=root;pwd=\"\"";


        public Login()
        {
            InitializeComponent();
        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {

        }
        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text;

            // Membuat koneksi ke database MySQL
            using (MySqlConnection connection = new MySqlConnection(conString))
            {
                connection.Open();

                // Membuat perintah SQL untuk memeriksa keberadaan pengguna dengan username dan password yang cocok
                string query = "SELECT role FROM Users WHERE Username=@username AND Password=@password";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string role = reader.GetString("role");

                        if (!string.IsNullOrEmpty(role))
                        {


                            if (role == "superadmin")
                            {
                                // Arahkan ke halaman admin
                                Beranda_superadmin superadmin = new Beranda_superadmin();
                                superadmin.Show();
                                this.Hide();
                            }
                            // Verifikasi login berhasil
                            else if (role == "Admin")
                            {
                                // Arahkan ke halaman admin
                                Beranda_Admin admin = new Beranda_Admin();
                                admin.Show();
                                this.Hide();
                            }
                            else if (role == "Mahasiswa")
                            {

                                // Arahkan ke halaman mahasiswa

                                Beranda mahasiswa = new Beranda();
                                mahasiswa.Show();


                                this.Hide();
                            }
                            else
                            {
                                // Role tidak dikenali
                                MessageBox.Show("Role tidak valid!");
                            }
                        }
                        else
                        {
                            // Verifikasi login gagal
                            MessageBox.Show("Username atau password salah!");
                        }
                    }
                    else
                    {
                        // Verifikasi login gagal
                        MessageBox.Show("Username atau password salah!");
                    }
                }
            }
        }


        private void Login_Load(object sender, EventArgs e)
        {



        }
    }
}




