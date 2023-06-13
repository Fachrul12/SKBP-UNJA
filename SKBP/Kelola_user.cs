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
    public partial class Kelola_user : Form
    {
        public Kelola_user()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_kelola_Click(object sender, EventArgs e)
        {

        }

        private void btn_petugas_Click(object sender, EventArgs e)
        {
            this.Hide();

            Info_Petugas petugas = new Info_Petugas();
            petugas.ShowDialog();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();

            Beranda_superadmin superadmin = new Beranda_superadmin();
            superadmin.ShowDialog();
        }
    }
}
