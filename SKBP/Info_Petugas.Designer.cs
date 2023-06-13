namespace SKBP
{
    partial class Info_Petugas
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
            navbar = new TableLayoutPanel();
            btn_kelola = new Button();
            btn_petugas = new Button();
            btn_dashboard = new Button();
            content = new Panel();
            btn_tambah = new Button();
            dataGridView1 = new DataGridView();
            username = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            nama = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            no_telepon = new DataGridViewTextBoxColumn();
            aksi = new DataGridViewButtonColumn();
            label2 = new Label();
            label_content = new Label();
            siderbar = new Panel();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            navbar.SuspendLayout();
            content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            siderbar.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            header.BorderStyle = BorderStyle.FixedSingle;
            header.Controls.Add(logo);
            header.Controls.Add(label1);
            header.Location = new Point(0, 6);
            header.Name = "header";
            header.Size = new Size(1239, 115);
            header.TabIndex = 10;
            header.Paint += header_Paint;
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
            logo.Click += logo_Click;
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
            label1.Click += label1_Click;
            // 
            // navbar
            // 
            navbar.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            navbar.ColumnCount = 1;
            navbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            navbar.Controls.Add(btn_kelola, 0, 2);
            navbar.Controls.Add(btn_petugas, 0, 1);
            navbar.Controls.Add(btn_dashboard, 0, 0);
            navbar.Location = new Point(3, 3);
            navbar.Name = "navbar";
            navbar.RowCount = 3;
            navbar.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            navbar.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            navbar.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            navbar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            navbar.Size = new Size(327, 304);
            navbar.TabIndex = 7;
            navbar.Paint += navbar_Paint;
            // 
            // btn_kelola
            // 
            btn_kelola.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_kelola.BackColor = Color.DarkOrange;
            btn_kelola.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_kelola.Location = new Point(4, 206);
            btn_kelola.Name = "btn_kelola";
            btn_kelola.Size = new Size(319, 94);
            btn_kelola.TabIndex = 3;
            btn_kelola.Text = "Kelola User";
            btn_kelola.UseVisualStyleBackColor = false;
            btn_kelola.Click += btn_kelola_Click;
            // 
            // btn_petugas
            // 
            btn_petugas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_petugas.BackColor = Color.DarkOrange;
            btn_petugas.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_petugas.Location = new Point(4, 105);
            btn_petugas.Name = "btn_petugas";
            btn_petugas.Size = new Size(319, 94);
            btn_petugas.TabIndex = 2;
            btn_petugas.Text = "Info Petugas";
            btn_petugas.UseVisualStyleBackColor = false;
            btn_petugas.Click += btn_petugas_Click;
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
            // content
            // 
            content.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            content.BorderStyle = BorderStyle.FixedSingle;
            content.Controls.Add(btn_tambah);
            content.Controls.Add(dataGridView1);
            content.Controls.Add(label2);
            content.Controls.Add(label_content);
            content.Location = new Point(341, 135);
            content.Name = "content";
            content.Size = new Size(886, 475);
            content.TabIndex = 12;
            content.Paint += content_Paint;
            // 
            // btn_tambah
            // 
            btn_tambah.BackColor = Color.DarkOrange;
            btn_tambah.Location = new Point(28, 72);
            btn_tambah.Name = "btn_tambah";
            btn_tambah.Size = new Size(152, 41);
            btn_tambah.TabIndex = 3;
            btn_tambah.Text = " + Tambah Petugas";
            btn_tambah.UseVisualStyleBackColor = false;
            btn_tambah.Click += btn_tambah_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { username, password, nama, email, no_telepon, aksi });
            dataGridView1.Location = new Point(28, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(837, 329);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // username
            // 
            username.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            username.HeaderText = "Username";
            username.MinimumWidth = 6;
            username.Name = "username";
            username.ReadOnly = true;
            // 
            // password
            // 
            password.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            password.HeaderText = "Password";
            password.MinimumWidth = 6;
            password.Name = "password";
            password.ReadOnly = true;
            // 
            // nama
            // 
            nama.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nama.HeaderText = "Nama";
            nama.MinimumWidth = 6;
            nama.Name = "nama";
            nama.ReadOnly = true;
            // 
            // email
            // 
            email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // no_telepon
            // 
            no_telepon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            no_telepon.HeaderText = "No_Telepon";
            no_telepon.MinimumWidth = 6;
            no_telepon.Name = "no_telepon";
            no_telepon.ReadOnly = true;
            // 
            // aksi
            // 
            aksi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            aksi.HeaderText = "aksi";
            aksi.MinimumWidth = 6;
            aksi.Name = "aksi";
            aksi.Text = "Hapus";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.Location = new Point(-1, 39);
            label2.Name = "label2";
            label2.Padding = new Padding(5);
            label2.Size = new Size(866, 342);
            label2.TabIndex = 1;
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // label_content
            // 
            label_content.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_content.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label_content.Location = new Point(-1, 0);
            label_content.Name = "label_content";
            label_content.Size = new Size(882, 39);
            label_content.TabIndex = 0;
            label_content.Text = "Info Petugas";
            label_content.TextAlign = ContentAlignment.MiddleCenter;
            label_content.Click += label_content_Click;
            // 
            // siderbar
            // 
            siderbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            siderbar.BorderStyle = BorderStyle.FixedSingle;
            siderbar.Controls.Add(navbar);
            siderbar.Location = new Point(0, 135);
            siderbar.Name = "siderbar";
            siderbar.Size = new Size(335, 475);
            siderbar.TabIndex = 11;
            siderbar.Paint += siderbar_Paint;
            // 
            // Info_Petugas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 616);
            Controls.Add(header);
            Controls.Add(content);
            Controls.Add(siderbar);
            Name = "Info_Petugas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Info_Petugas";
            WindowState = FormWindowState.Maximized;
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            navbar.ResumeLayout(false);
            content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            siderbar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel header;
        private PictureBox logo;
        private Label label1;
        private TableLayoutPanel navbar;
        private Button btn_kelola;
        private Button btn_petugas;
        private Button btn_dashboard;
        private Panel content;
        private Button btn_tambah;
        private Label label_content;
        private Panel siderbar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn nama;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn no_telepon;
        private DataGridViewButtonColumn aksi;
        private Label label2;
    }
}