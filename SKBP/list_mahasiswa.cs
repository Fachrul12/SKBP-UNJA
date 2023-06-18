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

namespace SKBP
{
    public partial class list_mahasiswa : Form
    {
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        private DataTable dataTable;
        private int selectedId;
        public list_mahasiswa()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_validasi_Click(object sender, EventArgs e)
        {
            this.Hide();

            Validasi validasi = new Validasi();
            validasi.ShowDialog();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();

            Beranda_Admin admin = new Beranda_Admin();
            admin.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login login = new Login();
            login.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void list_mahasiswa_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=db_skbp;uid=root;pwd=\"\"";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT nama, email, fakultas, prodi, create_at, status FROM skbp_form;";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);


                        // Loop melalui setiap baris di DataTable
                        foreach (DataRow row in dataTable.Rows)
                        {
                            // Cek nilai kolom "status" pada setiap baris
                            string status = row["status"].ToString();

                            // Jika nilai "status" terisi, maka data tidak akan muncul di DataGridView
                            if (!string.IsNullOrEmpty(status))
                            {
                                // Hapus baris dari DataTable
                                row.Delete();
                            }
                        }

                        // Terapkan perubahan pada DataTable
                        dataTable.AcceptChanges();

                        // Set DataTable sebagai sumber data untuk DataGridView
                        list_mhs.DataSource = dataTable;

                        // Atur tampilan kolom pada DataGridView
                        list_mhs.Columns["nama"].HeaderText = "Nama";
                        list_mhs.Columns["email"].HeaderText = "Email";
                        list_mhs.Columns["fakultas"].HeaderText = "Fakultas";
                        list_mhs.Columns["prodi"].HeaderText = "Prodi";
                        list_mhs.Columns["create_at"].HeaderText = "Tanggal Upload";
                        list_mhs.Columns["Status"].HeaderText = "Status";

                        list_mhs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
        }
    }
}
