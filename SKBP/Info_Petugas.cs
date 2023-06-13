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
    public partial class Info_Petugas : Form
    {
        public Info_Petugas()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();

            Beranda_superadmin beranda = new Beranda_superadmin();
            beranda.Show();
        }

        private void header_Paint(object sender, PaintEventArgs e)
        {
        }

        private void logo_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void navbar_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btn_kelola_Click(object sender, EventArgs e)
        {
            this.Hide();

            Kelola_user kelola = new Kelola_user();
            kelola.ShowDialog();

        }

        private void btn_petugas_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void content_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
        }

        private void label_content_Click(object sender, EventArgs e)
        {
        }

        private void siderbar_Paint(object sender, PaintEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
