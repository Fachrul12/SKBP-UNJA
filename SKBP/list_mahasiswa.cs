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
    public partial class list_mahasiswa : Form
    {
        public list_mahasiswa()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_validasi_Click(object sender, EventArgs e)
        {
            this.Hide();

            Validasi validasi = new Validasi();
            validasi.ShowDialog();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();

            Beranda_Admin admin = new Beranda_Admin();
            admin.ShowDialog();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login login = new Login();
            login.ShowDialog();
        }
    }
}
