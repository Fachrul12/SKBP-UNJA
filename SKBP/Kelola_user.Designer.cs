namespace SKBP
{
    partial class Kelola_user
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
            btn_kelola = new Button();
            btn_petugas = new Button();
            btn_dashboard = new Button();
            content = new Panel();
            btn_tambah = new Button();
            dataGridView1 = new DataGridView();
            username = new DataGridViewTextBoxColumn();
            password = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            aksi = new DataGridViewButtonColumn();
            hapus = new DataGridViewButtonColumn();
            label_content = new Label();
            logo = new PictureBox();
            label1 = new Label();
            header = new Panel();
            btn_logout = new Button();
            lbl_username = new Label();
            siderbar.SuspendLayout();
            navbar.SuspendLayout();
            content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            header.SuspendLayout();
            SuspendLayout();
            // 
            // siderbar
            // 
            siderbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            siderbar.BackColor = SystemColors.AppWorkspace;
            siderbar.BorderStyle = BorderStyle.FixedSingle;
            siderbar.Controls.Add(navbar);
            siderbar.Location = new Point(0, 135);
            siderbar.Name = "siderbar";
            siderbar.Size = new Size(335, 475);
            siderbar.TabIndex = 14;
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
            content.BackColor = SystemColors.AppWorkspace;
            content.BorderStyle = BorderStyle.FixedSingle;
            content.Controls.Add(btn_tambah);
            content.Controls.Add(dataGridView1);
            content.Controls.Add(label_content);
            content.Location = new Point(341, 135);
            content.Name = "content";
            content.Size = new Size(898, 475);
            content.TabIndex = 15;
            // 
            // btn_tambah
            // 
            btn_tambah.BackColor = Color.Gold;
            btn_tambah.Location = new Point(28, 72);
            btn_tambah.Name = "btn_tambah";
            btn_tambah.Size = new Size(152, 41);
            btn_tambah.TabIndex = 3;
            btn_tambah.Text = " + Tambah User";
            btn_tambah.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { username, password, role, aksi, hapus });
            dataGridView1.Location = new Point(28, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(851, 316);
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
            // role
            // 
            role.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            role.HeaderText = "Role";
            role.MinimumWidth = 6;
            role.Name = "role";
            // 
            // aksi
            // 
            aksi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            aksi.HeaderText = "Edit";
            aksi.MinimumWidth = 6;
            aksi.Name = "aksi";
            aksi.Text = "";
            // 
            // hapus
            // 
            hapus.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            hapus.HeaderText = "Hapus";
            hapus.MinimumWidth = 6;
            hapus.Name = "hapus";
            hapus.Resizable = DataGridViewTriState.True;
            hapus.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // label_content
            // 
            label_content.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_content.BackColor = Color.DarkOrange;
            label_content.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label_content.Location = new Point(-1, 0);
            label_content.Name = "label_content";
            label_content.Size = new Size(894, 39);
            label_content.TabIndex = 0;
            label_content.Text = "Kelola User";
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
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
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
            header.Location = new Point(0, 6);
            header.Name = "header";
            header.Size = new Size(1239, 115);
            header.TabIndex = 13;
            // 
            // btn_logout
            // 
            btn_logout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_logout.BackColor = Color.Silver;
            btn_logout.Cursor = Cursors.Hand;
            btn_logout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_logout.Location = new Point(1114, 44);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(94, 29);
            btn_logout.TabIndex = 19;
            btn_logout.Text = "Log Out";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
            // 
            // lbl_username
            // 
            lbl_username.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_username.Location = new Point(980, 45);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(128, 28);
            lbl_username.TabIndex = 20;
            lbl_username.Text = "SuperAdmin";
            // 
            // Kelola_user
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 616);
            Controls.Add(siderbar);
            Controls.Add(content);
            Controls.Add(header);
            Name = "Kelola_user";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kelola_user";
            WindowState = FormWindowState.Maximized;
            siderbar.ResumeLayout(false);
            navbar.ResumeLayout(false);
            content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            header.ResumeLayout(false);
            header.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel siderbar;
        private TableLayoutPanel navbar;
        private Button btn_kelola;
        private Button btn_petugas;
        private Button btn_dashboard;
        private Panel content;
        private Button btn_tambah;
        private DataGridView dataGridView1;
        private Label label_content;
        private PictureBox logo;
        private Label label1;
        private Panel header;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn role;
        private DataGridViewButtonColumn aksi;
        private DataGridViewButtonColumn hapus;
        private Button btn_logout;
        private Label lbl_username;
    }
}