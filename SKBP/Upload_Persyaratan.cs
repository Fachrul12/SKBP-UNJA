using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace SKBP
{
    public partial class Upload_persyaratan : Form
    {
        String conString = "server=localhost;database=db_skbp;uid=root;pwd=\"\"";
        private string ktmfilePath = "";
        private string sppfilePath = "";



        public Upload_persyaratan()
        {
            InitializeComponent();
        }

        private void btn_kirim_Click(object sender, EventArgs e)
        {

        }

        private void Upload_Persyaratan_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_ktm_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ktm = new OpenFileDialog())
            {
                ktm.Title = "Pilih File yang akan diupload";
                ktm.Filter = "File Teks|*.pdf|Semua File|*.*";

                if (ktm.ShowDialog() == DialogResult.OK)
                {
                    ktmfilePath = ktm.FileName;
                    MessageBox.Show("File Berhasil dipilih");
                }
            }
        }

        private void ktm_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btn_spp_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog spp = new OpenFileDialog())
            {
                spp.Title = "Pilih File yang akan diupload";
                spp.Filter = "File Teks|*.pdf|Semua File|*.*";

                if (spp.ShowDialog() == DialogResult.OK)
                {
                    sppfilePath = spp.FileName;
                    MessageBox.Show("File berhasil di upload");
                }
            }
        }

        private void label_konten_Click(object sender, EventArgs e)
        {

        }

        private void btn_riwayat_Click(object sender, EventArgs e)
        {
            this.Hide();  //Menyembunyikan form beranda
            Riwayat riwayat = new Riwayat();
            riwayat.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            this.Hide();  //Menyembunyikan form beranda

            Update_Persyaratan update_Persyaratan = new Update_Persyaratan();
            update_Persyaratan.ShowDialog();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();  //Menyembunyikan form beranda

            Beranda beranda = new Beranda();
            beranda.ShowDialog();
        }

        private void tb_nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ktm_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog ktm = new OpenFileDialog())
            {
                ktm.Title = "Pilih File yang akan diupload";
                ktm.Filter = "File Teks|*.pdf|Semua File|*.*";

                if (ktm.ShowDialog() == DialogResult.OK)
                {
                    ktmfilePath = ktm.FileName;
                    MessageBox.Show("File Berhasil dipilih");
                }
            }
        }

        private void btn_spp_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog spp = new OpenFileDialog())
            {
                spp.Title = "Pilih File yang akan diupload";
                spp.Filter = "File Teks|*.pdf|Semua File|*.*";

                if (spp.ShowDialog() == DialogResult.OK)
                {
                    sppfilePath = spp.FileName;
                    MessageBox.Show("File berhasil di upload");
                }
            }
        }

        private void btn_kirim_Click_1(object sender, EventArgs e)
        {

            string Nama = tb_nama.Text;
            string Email = tb_email.Text;
            string Nomor_WA = tb_noWa.Text;
            string Fakultas = tb_fakultas.Text;
            string Prodi = tb_prodi.Text;


            if (!string.IsNullOrEmpty(ktmfilePath) && !string.IsNullOrEmpty(sppfilePath))
            {
                string ktmfileContent = File.ReadAllText(ktmfilePath);
                string sppfileContent = File.ReadAllText(sppfilePath);

                using (MySqlConnection connection = new MySqlConnection(conString))
                {
                    connection.Open();

                    string query = $"INSERT INTO skbp_form (Nama,Email,Nomor_WA,Fakultas,Prodi,KTM,SPP) VALUES (@Nama,@Email,@Nomor_WA,@Fakultas,@Prodi,@ktmfileContent,@sppfileContent)";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    //VALUE
                    command.Parameters.AddWithValue("@Nama", Nama);
                    command.Parameters.AddWithValue("@Email", Email);
                    command.Parameters.AddWithValue("@Nomor_WA", Nomor_WA);
                    command.Parameters.AddWithValue("@Fakultas", Fakultas);
                    command.Parameters.AddWithValue("@Prodi", Prodi);
                    command.Parameters.AddWithValue("@ktmfileContent", ktmfileContent);
                    command.Parameters.AddWithValue("@sppfileContent", sppfileContent);


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data berhasil ditambah ke database");
                    }
                    else
                    {
                        MessageBox.Show("Gagal menambahkan data ke database");
                    }
                }

            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login login = new Login();
            login.ShowDialog();
        }
    }
}
