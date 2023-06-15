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
    public partial class Validasi : Form
    {
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
    }
}
