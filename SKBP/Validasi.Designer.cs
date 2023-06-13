namespace SKBP
{
    partial class Validasi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            siderbar = new Panel();
            navbar = new TableLayoutPanel();
            btn_list = new Button();
            btn_validasi = new Button();
            btn_dashboard = new Button();
            label_content = new Label();
            logo = new PictureBox();
            label1 = new Label();
            header = new Panel();
            content = new Panel();
            gb_data = new GroupBox();
            btn_tolak = new Button();
            btn_submit = new Button();
            label_prodi = new Label();
            skbp = new Button();
            label_fakultas = new Label();
            btn_ktm = new Button();
            btn_spp = new Button();
            label_nomorWA = new Label();
            label_email = new Label();
            label_nama = new Label();
            tb_prodi = new TextBox();
            tb_fakultas = new TextBox();
            tb_noWa = new TextBox();
            tb_email = new TextBox();
            tb_nama = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            siderbar.SuspendLayout();
            navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            header.SuspendLayout();
            content.SuspendLayout();
            gb_data.SuspendLayout();
            SuspendLayout();
            // 
            // siderbar
            // 
            siderbar.Controls.Add(navbar);
            siderbar.Location = new Point(3, 138);
            siderbar.Name = "siderbar";
            siderbar.Size = new Size(335, 475);
            siderbar.TabIndex = 16;
            // 
            // navbar
            // 
            navbar.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            navbar.ColumnCount = 1;
            navbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            navbar.Controls.Add(btn_list, 0, 2);
            navbar.Controls.Add(btn_validasi, 0, 1);
            navbar.Controls.Add(btn_dashboard, 0, 0);
            navbar.Location = new Point(3, 3);
            navbar.Name = "navbar";
            navbar.RowCount = 3;
            navbar.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            navbar.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            navbar.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            navbar.Size = new Size(327, 303);
            navbar.TabIndex = 6;
            // 
            // btn_list
            // 
            btn_list.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_list.BackColor = Color.DarkOrange;
            btn_list.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_list.Location = new Point(4, 206);
            btn_list.Name = "btn_list";
            btn_list.Size = new Size(319, 94);
            btn_list.TabIndex = 3;
            btn_list.Text = "List Mahasiswa";
            btn_list.UseVisualStyleBackColor = false;
            btn_list.Click += btn_list_Click;
            // 
            // btn_validasi
            // 
            btn_validasi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_validasi.BackColor = Color.DarkOrange;
            btn_validasi.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_validasi.Location = new Point(4, 105);
            btn_validasi.Name = "btn_validasi";
            btn_validasi.Size = new Size(319, 94);
            btn_validasi.TabIndex = 2;
            btn_validasi.Text = "Validasi";
            btn_validasi.UseVisualStyleBackColor = false;
            // 
            // btn_dashboard
            // 
            btn_dashboard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_dashboard.BackColor = Color.DarkOrange;
            btn_dashboard.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_dashboard.Location = new Point(4, 4);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Size = new Size(319, 94);
            btn_dashboard.TabIndex = 1;
            btn_dashboard.Text = "Dashboard";
            btn_dashboard.UseVisualStyleBackColor = false;
            btn_dashboard.Click += btn_dashboard_Click;
            // 
            // label_content
            // 
            label_content.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_content.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label_content.Location = new Point(3, -1);
            label_content.Name = "label_content";
            label_content.Size = new Size(852, 39);
            label_content.TabIndex = 0;
            label_content.Text = "Validasi";
            label_content.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logo
            // 
            logo.BackgroundImageLayout = ImageLayout.None;
            logo.Image = Properties.Resources.logo;
            logo.Location = new Point(9, 8);
            logo.Name = "logo";
            logo.Size = new Size(100, 96);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(115, 36);
            label1.Name = "label1";
            label1.Size = new Size(149, 35);
            label1.TabIndex = 0;
            label1.Text = "SKBP UNJA";
            // 
            // header
            // 
            header.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            header.BorderStyle = BorderStyle.FixedSingle;
            header.Controls.Add(logo);
            header.Controls.Add(label1);
            header.Location = new Point(1, 3);
            header.Name = "header";
            header.Size = new Size(1201, 115);
            header.TabIndex = 15;
            // 
            // content
            // 
            content.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            content.BorderStyle = BorderStyle.FixedSingle;
            content.Controls.Add(gb_data);
            content.Controls.Add(label_content);
            content.Location = new Point(347, 138);
            content.Name = "content";
            content.Size = new Size(860, 508);
            content.TabIndex = 17;
            // 
            // gb_data
            // 
            gb_data.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gb_data.BackColor = Color.DarkOrange;
            gb_data.Controls.Add(btn_tolak);
            gb_data.Controls.Add(btn_submit);
            gb_data.Controls.Add(label_prodi);
            gb_data.Controls.Add(skbp);
            gb_data.Controls.Add(label_fakultas);
            gb_data.Controls.Add(btn_ktm);
            gb_data.Controls.Add(btn_spp);
            gb_data.Controls.Add(label_nomorWA);
            gb_data.Controls.Add(label_email);
            gb_data.Controls.Add(label_nama);
            gb_data.Controls.Add(tb_prodi);
            gb_data.Controls.Add(tb_fakultas);
            gb_data.Controls.Add(tb_noWa);
            gb_data.Controls.Add(tb_email);
            gb_data.Controls.Add(tb_nama);
            gb_data.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            gb_data.Location = new Point(19, 41);
            gb_data.Name = "gb_data";
            gb_data.Size = new Size(772, 420);
            gb_data.TabIndex = 14;
            gb_data.TabStop = false;
            // 
            // btn_tolak
            // 
            btn_tolak.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_tolak.Location = new Point(207, 360);
            btn_tolak.Name = "btn_tolak";
            btn_tolak.Size = new Size(150, 41);
            btn_tolak.TabIndex = 21;
            btn_tolak.Text = "Tolak";
            btn_tolak.UseVisualStyleBackColor = true;
            // 
            // btn_submit
            // 
            btn_submit.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_submit.Location = new Point(12, 361);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(150, 41);
            btn_submit.TabIndex = 19;
            btn_submit.Text = "Validasi";
            btn_submit.UseVisualStyleBackColor = true;
            // 
            // label_prodi
            // 
            label_prodi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_prodi.AutoSize = true;
            label_prodi.BackColor = Color.SeaShell;
            label_prodi.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label_prodi.Location = new Point(12, 224);
            label_prodi.Name = "label_prodi";
            label_prodi.Size = new Size(75, 30);
            label_prodi.TabIndex = 10;
            label_prodi.Text = "Prodi :";
            // 
            // skbp
            // 
            skbp.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            skbp.Location = new Point(12, 314);
            skbp.Name = "skbp";
            skbp.Size = new Size(150, 41);
            skbp.TabIndex = 20;
            skbp.Text = "skbp";
            skbp.UseVisualStyleBackColor = true;
            // 
            // label_fakultas
            // 
            label_fakultas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_fakultas.AutoSize = true;
            label_fakultas.BackColor = Color.SeaShell;
            label_fakultas.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label_fakultas.Location = new Point(12, 175);
            label_fakultas.Name = "label_fakultas";
            label_fakultas.Size = new Size(100, 30);
            label_fakultas.TabIndex = 9;
            label_fakultas.Text = "Fakultas :";
            // 
            // btn_ktm
            // 
            btn_ktm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_ktm.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ktm.Location = new Point(616, 24);
            btn_ktm.Name = "btn_ktm";
            btn_ktm.Size = new Size(150, 41);
            btn_ktm.TabIndex = 15;
            btn_ktm.Text = "Unduh KTM";
            btn_ktm.UseVisualStyleBackColor = true;
            // 
            // btn_spp
            // 
            btn_spp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_spp.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_spp.Location = new Point(616, 87);
            btn_spp.Name = "btn_spp";
            btn_spp.Size = new Size(150, 39);
            btn_spp.TabIndex = 16;
            btn_spp.Text = "Unduh SPP";
            btn_spp.UseVisualStyleBackColor = true;
            // 
            // label_nomorWA
            // 
            label_nomorWA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_nomorWA.AutoSize = true;
            label_nomorWA.BackColor = Color.SeaShell;
            label_nomorWA.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label_nomorWA.Location = new Point(12, 127);
            label_nomorWA.Name = "label_nomorWA";
            label_nomorWA.Size = new Size(133, 30);
            label_nomorWA.TabIndex = 8;
            label_nomorWA.Text = "Nomor WA :";
            // 
            // label_email
            // 
            label_email.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_email.AutoSize = true;
            label_email.BackColor = Color.SeaShell;
            label_email.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label_email.Location = new Point(12, 74);
            label_email.Name = "label_email";
            label_email.Size = new Size(75, 30);
            label_email.TabIndex = 7;
            label_email.Text = "Email :";
            // 
            // label_nama
            // 
            label_nama.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_nama.AutoSize = true;
            label_nama.BackColor = Color.SeaShell;
            label_nama.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label_nama.Location = new Point(12, 24);
            label_nama.Name = "label_nama";
            label_nama.Size = new Size(81, 30);
            label_nama.TabIndex = 6;
            label_nama.Text = "Nama :";
            // 
            // tb_prodi
            // 
            tb_prodi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_prodi.Location = new Point(152, 224);
            tb_prodi.Name = "tb_prodi";
            tb_prodi.Size = new Size(335, 36);
            tb_prodi.TabIndex = 5;
            // 
            // tb_fakultas
            // 
            tb_fakultas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_fakultas.Location = new Point(152, 175);
            tb_fakultas.Name = "tb_fakultas";
            tb_fakultas.Size = new Size(335, 36);
            tb_fakultas.TabIndex = 4;
            // 
            // tb_noWa
            // 
            tb_noWa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_noWa.Location = new Point(152, 127);
            tb_noWa.Name = "tb_noWa";
            tb_noWa.Size = new Size(335, 36);
            tb_noWa.TabIndex = 3;
            // 
            // tb_email
            // 
            tb_email.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_email.Location = new Point(152, 74);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(335, 36);
            tb_email.TabIndex = 2;
            // 
            // tb_nama
            // 
            tb_nama.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_nama.Location = new Point(152, 24);
            tb_nama.Name = "tb_nama";
            tb_nama.Size = new Size(335, 36);
            tb_nama.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Validasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209, 650);
            Controls.Add(siderbar);
            Controls.Add(header);
            Controls.Add(content);
            Name = "Validasi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Validasi";
            WindowState = FormWindowState.Maximized;
            siderbar.ResumeLayout(false);
            navbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            header.ResumeLayout(false);
            header.PerformLayout();
            content.ResumeLayout(false);
            gb_data.ResumeLayout(false);
            gb_data.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel siderbar;
        private TableLayoutPanel navbar;
        private Button btn_list;
        private Button btn_validasi;
        private Button btn_dashboard;
        private Label label_content;
        private PictureBox logo;
        private Label label1;
        private Panel header;
        private Panel content;
        private GroupBox gb_data;
        private Label label_prodi;
        private Label label_fakultas;
        private Label label_nomorWA;
        private Label label_email;
        private Label label_nama;
        private TextBox tb_prodi;
        private TextBox tb_fakultas;
        private TextBox tb_noWa;
        private TextBox tb_email;
        private TextBox tb_nama;
        private Button btn_ktm;
        private Button skbp;
        private Button btn_submit;
        private Button btn_spp;
        private OpenFileDialog openFileDialog1;
        private Button btn_tolak;
    }
}