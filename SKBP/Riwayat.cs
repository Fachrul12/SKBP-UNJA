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
    }
}
