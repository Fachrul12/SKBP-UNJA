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
    }
}
