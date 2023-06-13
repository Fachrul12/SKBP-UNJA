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
    public partial class Beranda_superadmin : Form
    {
        public Beranda_superadmin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            this.Hide();

            Info_Petugas petugas = new Info_Petugas();
            petugas.ShowDialog();
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

        private void btn_update_Click(object sender, EventArgs e)
        {
            this.Hide();

            Kelola_user kelola = new Kelola_user();
            kelola.ShowDialog();
        }

        private void header_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
        }

        private void siderbar_Paint(object sender, PaintEventArgs e)
        {
        }

        private void content_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label_content_Click(object sender, EventArgs e)
        {
        }
    }
}
