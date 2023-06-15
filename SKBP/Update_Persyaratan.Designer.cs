namespace SKBP
{
    partial class Update_Persyaratan
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
            label2 = new Label();
            label1 = new Label();
            btn_update = new Button();
            btn_upload = new Button();
            btn_riwayat = new Button();
            logo = new PictureBox();
            btn_dashboard = new Button();
            header = new Panel();
            lbl_username = new Label();
            btn_logout = new Button();
            navbar = new TableLayoutPanel();
            content = new Panel();
            btn_kirim = new Button();
            btn_spp = new Button();
            btn_ktm = new Button();
            label_spp = new Label();
            label_ktm = new Label();
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
            label_konten = new Label();
            siderbar = new Panel();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            header.SuspendLayout();
            navbar.SuspendLayout();
            content.SuspendLayout();
            gb_data.SuspendLayout();
            siderbar.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = SystemColors.AppWorkspace;
            label2.Location = new Point(0, 42);
            label2.Name = "label2";
            label2.Padding = new Padding(5);
            label2.Size = new Size(894, 439);
            label2.TabIndex = 1;
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
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
            // btn_update
            // 
            btn_update.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_update.BackColor = Color.DarkOrange;
            btn_update.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update.Location = new Point(4, 206);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(319, 94);
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
            btn_upload.Size = new Size(319, 94);
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
            btn_riwayat.Size = new Size(319, 94);
            btn_riwayat.TabIndex = 3;
            btn_riwayat.Text = "Riwayat";
            btn_riwayat.UseVisualStyleBackColor = false;
            btn_riwayat.Click += btn_riwayat_Click;
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
            // btn_dashboard
            // 
            btn_dashboard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_dashboard.BackColor = Color.DarkOrange;
            btn_dashboard.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_dashboard.Location = new Point(4, 4);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Size = new Size(319, 94);
            btn_dashboard.TabIndex = 4;
            btn_dashboard.Text = "Dashboard";
            btn_dashboard.UseVisualStyleBackColor = false;
            btn_dashboard.Click += btn_dashboard_Click;
            // 
            // header
            // 
            header.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            header.BackColor = SystemColors.AppWorkspace;
            header.BorderStyle = BorderStyle.FixedSingle;
            header.Controls.Add(lbl_username);
            header.Controls.Add(btn_logout);
            header.Controls.Add(logo);
            header.Controls.Add(label1);
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(1239, 117);
            header.TabIndex = 9;
            // 
            // lbl_username
            // 
            lbl_username.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_username.Location = new Point(993, 43);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(116, 28);
            lbl_username.TabIndex = 11;
            lbl_username.Text = "Mahasiswa";
            // 
            // btn_logout
            // 
            btn_logout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_logout.BackColor = Color.Silver;
            btn_logout.Cursor = Cursors.Hand;
            btn_logout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_logout.Location = new Point(1115, 44);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(94, 29);
            btn_logout.TabIndex = 3;
            btn_logout.Text = "Log Out";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // navbar
            // 
            navbar.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            navbar.ColumnCount = 1;
            navbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            navbar.Controls.Add(btn_update, 0, 2);
            navbar.Controls.Add(btn_upload, 0, 1);
            navbar.Controls.Add(btn_riwayat, 0, 3);
            navbar.Controls.Add(btn_dashboard, 0, 0);
            navbar.Location = new Point(3, 3);
            navbar.Name = "navbar";
            navbar.RowCount = 4;
            navbar.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            navbar.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            navbar.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            navbar.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            navbar.Size = new Size(327, 403);
            navbar.TabIndex = 6;
            // 
            // content
            // 
            content.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            content.BorderStyle = BorderStyle.FixedSingle;
            content.Controls.Add(btn_kirim);
            content.Controls.Add(btn_spp);
            content.Controls.Add(btn_ktm);
            content.Controls.Add(label_spp);
            content.Controls.Add(label_ktm);
            content.Controls.Add(gb_data);
            content.Controls.Add(label2);
            content.Controls.Add(label_konten);
            content.Location = new Point(338, 121);
            content.Name = "content";
            content.Size = new Size(898, 486);
            content.TabIndex = 11;
            // 
            // btn_kirim
            // 
            btn_kirim.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_kirim.Location = new Point(747, 424);
            btn_kirim.Name = "btn_kirim";
            btn_kirim.Size = new Size(127, 39);
            btn_kirim.TabIndex = 12;
            btn_kirim.Text = "Kirim";
            btn_kirim.UseVisualStyleBackColor = true;
            btn_kirim.Click += btn_kirim_Click;
            // 
            // btn_spp
            // 
            btn_spp.Location = new Point(102, 385);
            btn_spp.Name = "btn_spp";
            btn_spp.Size = new Size(134, 39);
            btn_spp.TabIndex = 11;
            btn_spp.Text = "Upload File SPP";
            btn_spp.UseVisualStyleBackColor = true;
            btn_spp.Click += btn_spp_Click;
            // 
            // btn_ktm
            // 
            btn_ktm.Location = new Point(102, 337);
            btn_ktm.Name = "btn_ktm";
            btn_ktm.Size = new Size(134, 41);
            btn_ktm.TabIndex = 10;
            btn_ktm.Text = "Upload File KTM";
            btn_ktm.UseVisualStyleBackColor = true;
            btn_ktm.Click += btn_ktm_Click;
            // 
            // label_spp
            // 
            label_spp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_spp.AutoSize = true;
            label_spp.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label_spp.Location = new Point(25, 394);
            label_spp.Name = "label_spp";
            label_spp.Size = new Size(58, 30);
            label_spp.TabIndex = 9;
            label_spp.Text = "SPP*";
            // 
            // label_ktm
            // 
            label_ktm.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_ktm.AutoSize = true;
            label_ktm.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label_ktm.Location = new Point(25, 348);
            label_ktm.Name = "label_ktm";
            label_ktm.Size = new Size(67, 30);
            label_ktm.TabIndex = 8;
            label_ktm.Text = "KTM*";
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
            gb_data.Location = new Point(13, 56);
            gb_data.Name = "gb_data";
            gb_data.Size = new Size(874, 275);
            gb_data.TabIndex = 7;
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
            label_fakultas.Location = new Point(12, 181);
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
            label_email.Location = new Point(12, 80);
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
            tb_prodi.Size = new Size(420, 36);
            tb_prodi.TabIndex = 5;
            // 
            // tb_fakultas
            // 
            tb_fakultas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_fakultas.Location = new Point(152, 175);
            tb_fakultas.Name = "tb_fakultas";
            tb_fakultas.Size = new Size(420, 36);
            tb_fakultas.TabIndex = 4;
            // 
            // tb_noWa
            // 
            tb_noWa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_noWa.Location = new Point(152, 127);
            tb_noWa.Name = "tb_noWa";
            tb_noWa.Size = new Size(420, 36);
            tb_noWa.TabIndex = 3;
            // 
            // tb_email
            // 
            tb_email.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_email.Location = new Point(152, 74);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(420, 36);
            tb_email.TabIndex = 2;
            // 
            // tb_nama
            // 
            tb_nama.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_nama.Location = new Point(152, 24);
            tb_nama.Name = "tb_nama";
            tb_nama.Size = new Size(420, 36);
            tb_nama.TabIndex = 0;
            // 
            // label_konten
            // 
            label_konten.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_konten.BackColor = Color.DarkOrange;
            label_konten.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label_konten.Location = new Point(0, 0);
            label_konten.Name = "label_konten";
            label_konten.Size = new Size(895, 42);
            label_konten.TabIndex = 0;
            label_konten.Text = "Update Persyaratan SKBP";
            label_konten.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // siderbar
            // 
            siderbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            siderbar.BackColor = SystemColors.AppWorkspace;
            siderbar.BorderStyle = BorderStyle.FixedSingle;
            siderbar.Controls.Add(navbar);
            siderbar.Location = new Point(0, 121);
            siderbar.Name = "siderbar";
            siderbar.Size = new Size(335, 486);
            siderbar.TabIndex = 10;
            // 
            // Update_Persyaratan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 616);
            Controls.Add(header);
            Controls.Add(content);
            Controls.Add(siderbar);
            Name = "Update_Persyaratan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update_Persyaratan";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            header.ResumeLayout(false);
            header.PerformLayout();
            navbar.ResumeLayout(false);
            content.ResumeLayout(false);
            content.PerformLayout();
            gb_data.ResumeLayout(false);
            gb_data.PerformLayout();
            siderbar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btn_update;
        private Button btn_upload;
        private Button btn_riwayat;
        private PictureBox logo;
        private Button btn_dashboard;
        private Panel header;
        private TableLayoutPanel navbar;
        private Panel content;
        private Label label_konten;
        private Panel siderbar;
        private Button btn_kirim;
        private Button btn_spp;
        private Button btn_ktm;
        private Label label_spp;
        private Label label_ktm;
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
        private Button btn_logout;
        private Label lbl_username;
    }
}