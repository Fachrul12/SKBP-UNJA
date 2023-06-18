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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SKBP
{
    public partial class Validasi : Form
    {
        String conString = "server=localhost;database=db_skbp;uid=root;pwd=\"\"";
        MySqlConnection connection;
        private byte[] ktmFileData;
        private string ktmFileName;
        private byte[] sppFileData;
        private string sppFileName;
        private string file_skbpfilePath = "";
        public Validasi()
        {
            InitializeComponent();
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            this.Hide();

            list_mahasiswa list = new list_mahasiswa();
            list.ShowDialog();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();

            Beranda_Admin admin = new Beranda_Admin();
            admin.ShowDialog();
        }

        private void content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login login = new Login();
            login.ShowDialog();
        }

        private void cmb_nama_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = cmb_nama.SelectedItem.ToString();

            string query = "SELECT nama,email,nomor_wa,fakultas,prodi,ktm,spp,status,file_skbp,pesan FROM skbp_form WHERE nama=@Nama AND status=''";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Nama", selectedName);

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                //ini nanti jadi tempat dimano be texboxt nyo yang bakal diisi
                tb_nama.Text = reader["nama"].ToString();
                tb_email.Text = reader["email"].ToString();
                tb_noWa.Text = reader["nomor_wa"].ToString();
                tb_fakultas.Text = reader["fakultas"].ToString();
                tb_prodi.Text = reader["prodi"].ToString();

            }

            reader.Close();
        }

        private void Validasi_Load(object sender, EventArgs e)
        {
            connection = new MySqlConnection(conString);
            connection.Open();

            string query = "SELECT nama FROM skbp_form";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                cmb_nama.Items.Add(reader["Nama"].ToString());
            }

            reader.Close();
        }

        private void btn_ktm_Click(object sender, EventArgs e)
        {

        }

        private void btn_spp_Click(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string pesan = tb_pesan.Text;
            tb_pesan. Text = pesan;

            if (!string.IsNullOrEmpty(file_skbpfilePath))
            {
                string file_skbpfileContent = File.ReadAllText(file_skbpfilePath);

                using (MySqlConnection connection = new MySqlConnection(conString))
                {
                    connection.Open();

                    // Mengupdate status menjadi "accepted"
                    string updateStatusQuery = "UPDATE skbp_form SET status = @status, pesan = @pesan, file_skbp = @file_skbp WHERE nama = @Nama";
                    using (MySqlCommand updateCommand = new MySqlCommand(updateStatusQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@status", "accepted");
                        updateCommand.Parameters.AddWithValue("@pesan", pesan);
                        updateCommand.Parameters.AddWithValue("@file_skbp", file_skbpfileContent);
                        updateCommand.Parameters.AddWithValue("@Nama", cmb_nama.SelectedItem.ToString());

                        updateCommand.ExecuteNonQuery();

                    }

                    

                    connection.Close();
                }

            }
        }

        

        private void btn_tolak_Click(object sender, EventArgs e)
        {

        }
        
        private void btn_skbp_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog file_skbp = new OpenFileDialog())
            {
                file_skbp.Title = "Pilih File yang akan diupload";
                file_skbp.Filter = "File Teks|*.pdf|Semua File|*.*";

                if (file_skbp.ShowDialog() == DialogResult.OK)
                {
                    file_skbpfilePath = file_skbp.FileName;
                    MessageBox.Show("File Berhasil dipilih");
                }
            }
        }
    }
}
