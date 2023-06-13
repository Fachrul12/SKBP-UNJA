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
    public partial class Beranda_Admin : Form
    {
        public Beranda_Admin()
        {
            InitializeComponent();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {

        }

        private void btn_validasi_Click(object sender, EventArgs e)
        {
            this.Hide();

            Validasi validasi = new Validasi();
            validasi.ShowDialog();
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            this.Hide();

            list_mahasiswa list = new list_mahasiswa();
            list.ShowDialog();
        }

        private void siderbar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
