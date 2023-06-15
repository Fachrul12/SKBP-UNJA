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
    public partial class Update_Persyaratan : Form
    {
        String conString = "server=localhost;database=db_skbp;uid=root;pwd=\"\"";
        private string ktmfilePath = "";
        private string sppfilePath = "";
        public Update_Persyaratan()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();  //Menyembunyikan form beranda

            Beranda beranda = new Beranda();
            beranda.ShowDialog();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            this.Hide();  //Menyembunyikan form beranda

            Upload_persyaratan upload_Persyaratan = new Upload_persyaratan();
            upload_Persyaratan.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void btn_riwayat_Click(object sender, EventArgs e)
        {
            this.Hide();  //Menyembunyikan form beranda

            Riwayat riwayat = new Riwayat();
            riwayat.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login login = new Login();
            login.ShowDialog();
        }

        private void btn_kirim_Click(object sender, EventArgs e)
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

                    string query = $"UPDATE skbp_form SET Nama=@Nama,Email=@Email,Nomor_WA=@Nomor_WA,Fakultas=@Fakultas,Prodi=@Prodi,KTM=@ktmfileContent,SPP=@sppfileContent WHERE 7";
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
    }
}
