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
            btn_logout = new Button();
            content = new Panel();
            splitContainer1 = new SplitContainer();
            label_nama = new Label();
            label_email = new Label();
            tb_nama = new TextBox();
            tb_email = new TextBox();
            label_nomorWA = new Label();
            label_fakultas = new Label();
            tb_noWa = new TextBox();
            label_prodi = new Label();
            tb_fakultas = new TextBox();
            btn_spp = new Button();
            btn_ktm = new Button();
            tb_prodi = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            btn_submit = new Button();
            skbp = new Button();
            btn_tolak = new Button();
            openFileDialog1 = new OpenFileDialog();
            lbl_username = new Label();
            siderbar.SuspendLayout();
            navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            header.SuspendLayout();
            content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // siderbar
            // 
            siderbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            siderbar.BackColor = SystemColors.AppWorkspace;
            siderbar.Controls.Add(navbar);
            siderbar.Location = new Point(3, 129);
            siderbar.Name = "siderbar";
            siderbar.Size = new Size(335, 491);
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
            label_content.BackColor = Color.DarkOrange;
            label_content.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label_content.Location = new Point(0, 0);
            label_content.Name = "label_content";
            label_content.Size = new Size(855, 39);
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
            header.BackColor = SystemColors.AppWorkspace;
            header.BorderStyle = BorderStyle.FixedSingle;
            header.Controls.Add(lbl_username);
            header.Controls.Add(btn_logout);
            header.Controls.Add(logo);
            header.Controls.Add(label1);
            header.Location = new Point(1, 3);
            header.Name = "header";
            header.Size = new Size(1201, 115);
            header.TabIndex = 15;
            // 
            // btn_logout
            // 
            btn_logout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_logout.BackColor = Color.Silver;
            btn_logout.Cursor = Cursors.Hand;
            btn_logout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_logout.Location = new Point(1073, 44);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(94, 29);
            btn_logout.TabIndex = 18;
            btn_logout.Text = "Log Out";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // content
            // 
            content.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            content.BackColor = SystemColors.AppWorkspace;
            content.BorderStyle = BorderStyle.FixedSingle;
            content.Controls.Add(splitContainer1);
            content.Controls.Add(label_content);
            content.Location = new Point(347, 129);
            content.Name = "content";
            content.Size = new Size(860, 491);
            content.TabIndex = 17;
            content.Paint += content_Paint;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(17, 58);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.DarkOrange;
            splitContainer1.Panel1.Controls.Add(label_nama);
            splitContainer1.Panel1.Controls.Add(label_email);
            splitContainer1.Panel1.Controls.Add(tb_nama);
            splitContainer1.Panel1.Controls.Add(tb_email);
            splitContainer1.Panel1.Controls.Add(label_nomorWA);
            splitContainer1.Panel1.Controls.Add(label_fakultas);
            splitContainer1.Panel1.Controls.Add(tb_noWa);
            splitContainer1.Panel1.Controls.Add(label_prodi);
            splitContainer1.Panel1.Controls.Add(tb_fakultas);
            splitContainer1.Panel1.Controls.Add(btn_spp);
            splitContainer1.Panel1.Controls.Add(btn_ktm);
            splitContainer1.Panel1.Controls.Add(tb_prodi);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.DarkOrange;
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(textBox1);
            splitContainer1.Panel2.Controls.Add(btn_submit);
            splitContainer1.Panel2.Controls.Add(skbp);
            splitContainer1.Panel2.Controls.Add(btn_tolak);
            splitContainer1.Size = new Size(832, 417);
            splitContainer1.SplitterDistance = 416;
            splitContainer1.TabIndex = 15;
            // 
            // label_nama
            // 
            label_nama.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_nama.AutoSize = true;
            label_nama.BackColor = Color.SeaShell;
            label_nama.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label_nama.Location = new Point(12, 26);
            label_nama.Name = "label_nama";
            label_nama.Size = new Size(81, 30);
            label_nama.TabIndex = 6;
            label_nama.Text = "Nama :";
            // 
            // label_email
            // 
            label_email.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_email.AutoSize = true;
            label_email.BackColor = Color.SeaShell;
            label_email.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label_email.Location = new Point(12, 83);
            label_email.Name = "label_email";
            label_email.Size = new Size(75, 30);
            label_email.TabIndex = 7;
            label_email.Text = "Email :";
            // 
            // tb_nama
            // 
            tb_nama.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_nama.Location = new Point(160, 31);
            tb_nama.Name = "tb_nama";
            tb_nama.Size = new Size(231, 27);
            tb_nama.TabIndex = 0;
            // 
            // tb_email
            // 
            tb_email.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_email.Location = new Point(160, 86);
            tb_email.Name = "tb_email";
            tb_email.Size = new Size(231, 27);
            tb_email.TabIndex = 2;
            // 
            // label_nomorWA
            // 
            label_nomorWA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_nomorWA.AutoSize = true;
            label_nomorWA.BackColor = Color.SeaShell;
            label_nomorWA.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label_nomorWA.Location = new Point(12, 136);
            label_nomorWA.Name = "label_nomorWA";
            label_nomorWA.Size = new Size(133, 30);
            label_nomorWA.TabIndex = 8;
            label_nomorWA.Text = "Nomor WA :";
            // 
            // label_fakultas
            // 
            label_fakultas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_fakultas.AutoSize = true;
            label_fakultas.BackColor = Color.SeaShell;
            label_fakultas.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label_fakultas.Location = new Point(12, 199);
            label_fakultas.Name = "label_fakultas";
            label_fakultas.Size = new Size(100, 30);
            label_fakultas.TabIndex = 9;
            label_fakultas.Text = "Fakultas :";
            // 
            // tb_noWa
            // 
            tb_noWa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_noWa.Location = new Point(160, 141);
            tb_noWa.Name = "tb_noWa";
            tb_noWa.Size = new Size(231, 27);
            tb_noWa.TabIndex = 3;
            // 
            // label_prodi
            // 
            label_prodi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label_prodi.AutoSize = true;
            label_prodi.BackColor = Color.SeaShell;
            label_prodi.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label_prodi.Location = new Point(18, 262);
            label_prodi.Name = "label_prodi";
            label_prodi.Size = new Size(75, 30);
            label_prodi.TabIndex = 10;
            label_prodi.Text = "Prodi :";
            // 
            // tb_fakultas
            // 
            tb_fakultas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_fakultas.Location = new Point(160, 202);
            tb_fakultas.Name = "tb_fakultas";
            tb_fakultas.Size = new Size(231, 27);
            tb_fakultas.TabIndex = 4;
            // 
            // btn_spp
            // 
            btn_spp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_spp.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_spp.Location = new Point(241, 362);
            btn_spp.Name = "btn_spp";
            btn_spp.Size = new Size(150, 39);
            btn_spp.TabIndex = 16;
            btn_spp.Text = "Unduh SPP";
            btn_spp.UseVisualStyleBackColor = true;
            // 
            // btn_ktm
            // 
            btn_ktm.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_ktm.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ktm.Location = new Point(33, 360);
            btn_ktm.Name = "btn_ktm";
            btn_ktm.Size = new Size(150, 41);
            btn_ktm.TabIndex = 15;
            btn_ktm.Text = "Unduh KTM";
            btn_ktm.UseVisualStyleBackColor = true;
            // 
            // tb_prodi
            // 
            tb_prodi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_prodi.Location = new Point(160, 267);
            tb_prodi.Name = "tb_prodi";
            tb_prodi.Size = new Size(231, 27);
            tb_prodi.TabIndex = 5;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.SeaShell;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 31);
            label2.Name = "label2";
            label2.Size = new Size(68, 30);
            label2.TabIndex = 17;
            label2.Text = "Pesan";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(19, 71);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(376, 192);
            textBox1.TabIndex = 22;
            // 
            // btn_submit
            // 
            btn_submit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_submit.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_submit.Location = new Point(234, 360);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(150, 41);
            btn_submit.TabIndex = 19;
            btn_submit.Text = "Validasi";
            btn_submit.UseVisualStyleBackColor = true;
            // 
            // skbp
            // 
            skbp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            skbp.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            skbp.Location = new Point(234, 295);
            skbp.Name = "skbp";
            skbp.Size = new Size(150, 41);
            skbp.TabIndex = 20;
            skbp.Text = "skbp";
            skbp.UseVisualStyleBackColor = true;
            // 
            // btn_tolak
            // 
            btn_tolak.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_tolak.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_tolak.Location = new Point(32, 360);
            btn_tolak.Name = "btn_tolak";
            btn_tolak.Size = new Size(150, 41);
            btn_tolak.TabIndex = 21;
            btn_tolak.Text = "Tolak";
            btn_tolak.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbl_username
            // 
            lbl_username.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_username.Location = new Point(993, 44);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(74, 28);
            lbl_username.TabIndex = 18;
            lbl_username.Text = "Admin";
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
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
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
        private Button btn_logout;
        private SplitContainer splitContainer1;
        private Label label2;
        private TextBox textBox1;
        private Label lbl_username;
    }
}