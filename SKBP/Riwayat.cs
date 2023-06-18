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
    public partial class Riwayat : Form
    {
        private MySqlConnection connection;
        private MySqlDataAdapter adapter;
        private DataTable dataTable;
        private int selectedId;

        public Riwayat()
        {
            InitializeComponent();
        }


        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();  //Menyembunyikan form beranda

            Beranda beranda = new Beranda();
            beranda.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();  //Menyembunyikan form beranda

            Upload_persyaratan upload_Persyaratan = new Upload_persyaratan();
            upload_Persyaratan.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();  //Menyembunyikan form beranda

            Update_Persyaratan update_Persyaratan = new Update_Persyaratan();
            update_Persyaratan.ShowDialog();
        }

        private void btn_riwayat_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login login = new Login();
            login.ShowDialog();
        }

        private void view_riwayat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Riwayat_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=db_skbp;uid=root;pwd=\"\"";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT id,create_at,validasi_at,status FROM skbp_form;";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        view_riwayat.DataSource = dataTable;

                        view_riwayat.Columns["id"].HeaderText = "Periode";
                        view_riwayat.Columns["create_at"].HeaderText = "Tanggal Pembuatan";
                        view_riwayat.Columns["validasi_at"].HeaderText = "Tanggal Validasi";
                        view_riwayat.Columns["status"].HeaderText = "Status";

                        view_riwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
        }

        private void Riwayat_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}



