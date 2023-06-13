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
    public partial class Beranda : Form
    {
        private string loggedInUsername;
        public Beranda()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            this.Hide();  //Menyembunyikan form beranda

            Upload_persyaratan upload_Persyaratan = new Upload_persyaratan();
            upload_Persyaratan.ShowDialog();

        }

        private void Beranda_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            this.Hide();  //Menyembunyikan form beranda

            Update_Persyaratan update_Persyaratan = new Update_Persyaratan();
            update_Persyaratan.ShowDialog();
        }

        private void btn_riwayat_Click(object sender, EventArgs e)
        {
            this.Hide();  //Menyembunyikan form beranda

            Riwayat riwayat = new Riwayat();
            riwayat.ShowDialog();
        }

        private void logo_Click(object sender, EventArgs e)
        {
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {

        }

        private void header_Paint(object sender, PaintEventArgs e)
        {
        }

        private void navbar_Paint(object sender, PaintEventArgs e)
        {
        }

        private void siderbar_Paint(object sender, PaintEventArgs e)
        {
        }

        private void content_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lbl_dashboard_Click(object sender, EventArgs e)
        {
        }
    }
}
