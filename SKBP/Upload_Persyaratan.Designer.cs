namespace SKBP
{
    partial class Upload_persyaratan
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
            header = new Panel();
            logo = new PictureBox();
            label1 = new Label();
            siderbar = new Panel();
            navbar = new TableLayoutPanel();
            btn_update = new Button();
            btn_upload = new Button();
            btn_riwayat = new Button();
            btn_dashboard = new Button();
            label_konten = new Label();
            konten = new Panel();
            btn_kirim = new Button();
            label_spp = new Label();
            label_ktm = new Label();
            btn_spp = new Button();
            btn_ktm = new Button();
            gb_data = new GroupBox();
            label_prodi = new Label();
            label_fakultas = new Label();
            label_nomorWA = new Label();
            label_email = new Label();
            label_nama = new Label();
            tb_prodi = new TextBox();
            tb_fakultas = new TextBox();
            tb_noWa = new TextBox();
            tb_email = new TextBox();
            tb_nama = new TextBox();
            sidebar = new Panel();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            siderbar.SuspendLayout();
            navbar.SuspendLayout();
            konten.SuspendLayout();
            gb_data.SuspendLayout();
            sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            header.BorderStyle = BorderStyle.FixedSingle;
            header.Controls.Add(logo);
            header.Controls.Add(label1);
            header.Location = new Point(-2, -2);
            header.Name = "header";
            header.Size = new Size(1268, 119);
            header.TabIndex = 10;
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
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(115, 36);
            label1.Name = "label1";
            label1.Size = new Size(149, 35);
            label1.TabIndex = 0;
            label1.Text = "SKBP UNJA";
            // 
            // siderbar
            // 
            siderbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            siderbar.BorderStyle = BorderStyle.FixedSingle;
            siderbar.Controls.Add(navbar);
            siderbar.Location = new Point(3, 3);
            siderbar.Name = "siderbar";
            siderbar.Size = new Size(327, 403);
            siderbar.TabIndex = 11;
            // 
            // navbar
            // 
            navbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            navbar.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            navbar.ColumnCount = 1;
            navbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            navbar.Controls.Add(btn_update, 0, 2);
            navbar.Controls.Add(btn_upload, 0, 1);
            navbar.Controls.Add(btn_riwayat, 0, 3);
            navbar.Controls.Add(btn_dashboard, 0, 0);
            navbar.Location = new Point(-1, 1);
            navbar.Name = "navbar";
            navbar.RowCount = 4;
            navbar.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            navbar.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            navbar.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            navbar.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            navbar.Size = new Size(331, 397);
            navbar.TabIndex = 6;
            // 
            // btn_update
            // 
            btn_update.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_update.BackColor = Color.DarkOrange;
            btn_update.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update.Location = new Point(4, 206);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(323, 94);
            btn_update.TabIndex = 2;
            btn_update.Text = "Update Persyaratan";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_upload
            // 
            btn_upload.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_upload.BackColor = Color.DarkOrange;
            btn_upload.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_upload.Location = new Point(4, 105);
            btn_upload.Name = "btn_upload";
            btn_upload.Size = new Size(323, 94);
            btn_upload.TabIndex = 1;
            btn_upload.Text = "Upload Persyaratan";
            btn_upload.UseVisualStyleBackColor = false;
            btn_upload.Click += btn_upload_Click;
            // 
            // btn_riwayat
            // 
            btn_riwayat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_riwayat.BackColor = Color.DarkOrange;
            btn_riwayat.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_riwayat.Location = new Point(4, 307);
            btn_riwayat.Name = "btn_riwayat";
            btn_riwayat.Size = new Size(323, 94);
            btn_riwayat.TabIndex = 3;
            btn_riwayat.Text = "Riwayat";
            btn_riwayat.UseVisualStyleBackColor = false;
            btn_riwayat.Click += btn_riwayat_Click;
            // 
            // btn_dashboard
            // 
            btn_dashboard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_dashboard.BackColor = Color.DarkOrange;
            btn_dashboard.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_dashboard.Location = new Point(4, 4);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Size = new Size(323, 94);
            btn_dashboard.TabIndex = 4;
            btn_dashboard.Text = "Dashboard";
            btn_dashboard.UseVisualStyleBackColor = false;
            btn_dashboard.Click += btn_dashboard_Click;
            // 
            // label_konten
            // 
            label_konten.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_konten.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label_konten.Location = new Point(3, 3);
            label_konten.Name = "label_konten";
            label_konten.Size = new Size(923, 39);
            label_konten.TabIndex = 0;
            label_konten.Text = "Upload Persyaratan SKBP";
            label_konten.TextAlign = ContentAlignment.MiddleCenter;
            label_konten.Click += label_konten_Click;
            // 
            // konten
            // 
            konten.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            konten.BackgroundImageLayout = ImageLayout.None;
            konten.BorderStyle = BorderStyle.FixedSingle;
            konten.Controls.Add(btn_kirim);
            konten.Controls.Add(label_spp);
            konten.Controls.Add(label_ktm);
            konten.Controls.Add(btn_spp);
            konten.Controls.Add(btn_ktm);
            konten.Controls.Add(gb_data);
            konten.Controls.Add(label_konten);
            konten.Location = new Point(338, 121);
            konten.Name = "konten";
            konten.Size = new Size(931, 485);
            konten.TabIndex = 12;
            // 
            // btn_kirim
            // 
            btn_kirim.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_kirim.Location = new Point(781, 425);
            btn_kirim.Name = "btn_kirim";
            btn_kirim.Size = new Size(127, 39);
            btn_kirim.TabIndex = 15;
            btn_kirim.Text = "Kirim";
            btn_kirim.UseVisualStyleBackColor = true;
            btn_kirim.Click += btn_kirim_Click_1;
            // 
            // label_spp
            // 
            label_spp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_spp.AutoSize = true;
            label_spp.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label_spp.Location = new Point(26, 395);
            label_spp.Name = "label_spp";
            label_spp.Size = new Size(58, 30);
            label_spp.TabIndex = 14;
            label_spp.Text = "SPP*";
            // 
            // label_ktm
            // 
            label_ktm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_ktm.AutoSize = true;
            label_ktm.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label_ktm.Location = new Point(26, 337);
            label_ktm.Name = "label_ktm";
            label_ktm.Size = new Size(67, 30);
            label_ktm.TabIndex = 13;
            label_ktm.Text = "KTM*";
            // 
            // btn_spp
            // 
            btn_spp.Location = new Point(102, 395);
            btn_spp.Name = "btn_spp";
            btn_spp.Size = new Size(134, 39);
            btn_spp.TabIndex = 12;
            btn_spp.Text = "Upload File SPP";
            btn_spp.UseVisualStyleBackColor = true;
            btn_spp.Click += btn_spp_Click_1;
            // 
            // btn_ktm
            // 
            btn_ktm.Location = new Point(102, 337);
            btn_ktm.Name = "btn_ktm";
            btn_ktm.Size = new Size(134, 41);
            btn_ktm.TabIndex = 11;
            btn_ktm.Text = "Upload File KTM";
            btn_ktm.UseVisualStyleBackColor = true;
            btn_ktm.Click += btn_ktm_Click_1;
            // 
            // gb_data
            // 
            gb_data.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gb_data.BackColor = Color.DarkOrange;
            gb_data.Controls.Add(label_prodi);
            gb_data.Controls.Add(label_fakultas);
            gb_data.Controls.Add(label_nomorWA);
            gb_data.Controls.Add(label_email);
            gb_data.Controls.Add(label_nama);
            gb_data.Controls.Add(tb_prodi);
            gb_data.Controls.Add(tb_fakultas);
            gb_data.Controls.Add(tb_noWa);
            gb_data.Controls.Add(tb_email);
            gb_data.Controls.Add(tb_nama);
            gb_data.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            gb_data.Location = new Point(14, 45);
            gb_data.Name = "gb_data";
            gb_data.Size = new Size(905, 275);
            gb_data.TabIndex = 8;
            gb_data.TabStop = false;
            // 
            // label_prodi
            // 
            label_prodi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_prodi.AutoSize = true;
            label_prodi.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label_prodi.Location = new Point(12, 224);
            label_prodi.Name = "label_prodi";
            label_prodi.Size = new Size(75, 30);
            label_prodi.TabIndex = 10;
            label_prodi.Text = "Prodi :";
            // 
            // label_fakultas
            // 
            label_fakultas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_fakultas.AutoSize = true;
            label_fakultas.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label_fakultas.Location = new Point(12, 175);
            label_fakultas.Name = "label_fakultas";
            label_fakultas.Size = new Size(100, 30);
            label_fakultas.TabIndex = 9;
            label_fakultas.Text = "Fakultas :";
            // 
            // label_nomorWA
            // 
            label_nomorWA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_nomorWA.AutoSize = true;
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
            tb_prodi.Size = new Size(451, 36);
            tb_prodi.TabIndex = 5;
            // 
            // tb_fakultas
            // 
            tb_fakultas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_fakultas.Location = new Point(152, 175);
            tb_fakultas.Name = "tb_fakultas";
            tb_fakultas.Size = new Size(451, 36);
            tb_fakultas.TabIndex = 4;
            // 
            // tb_noWa
            // 
            tb_noWa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_noWa.Location = new Point(152, 127);
            tb_noWa.Name = "tb_noWa";
            tb_noWa.Size = new Size(451, 36);
            tb_noWa.TabIndex = 3;
            // 
            // tb_email
            // 
            tb_email.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_email.Location = new Point(152, 74);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(451, 36);
            tb_email.TabIndex = 2;
            // 
            // tb_nama
            // 
            tb_nama.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_nama.Location = new Point(152, 24);
            tb_nama.Name = "tb_nama";
            tb_nama.Size = new Size(451, 36);
            tb_nama.TabIndex = 0;
            tb_nama.TextChanged += tb_nama_TextChanged;
            // 
            // sidebar
            // 
            sidebar.BorderStyle = BorderStyle.FixedSingle;
            sidebar.Controls.Add(siderbar);
            sidebar.Location = new Point(0, 121);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(335, 486);
            sidebar.TabIndex = 13;
            // 
            // Upload_persyaratan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 614);
            Controls.Add(sidebar);
            Controls.Add(konten);
            Controls.Add(header);
            Name = "Upload_persyaratan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upload_Persyaratan";
            WindowState = FormWindowState.Maximized;
            Load += Upload_Persyaratan_Load;
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            siderbar.ResumeLayout(false);
            navbar.ResumeLayout(false);
            konten.ResumeLayout(false);
            konten.PerformLayout();
            gb_data.ResumeLayout(false);
            gb_data.PerformLayout();
            sidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel header;
        private PictureBox logo;
        private Label label1;
        private Panel siderbar;
        private TableLayoutPanel navbar;
        private Button btn_update;
        private Button btn_upload;
        private Button btn_riwayat;
        private Button btn_dashboard;
        private Label label_konten;
        private Panel konten;
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
        private Panel sidebar;
        private Button btn_ktm;
        private Button btn_spp;
        private Label label_ktm;
        private Label label_spp;
        private Button btn_kirim;
    }
}