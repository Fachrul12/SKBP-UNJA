namespace SKBP
{
    partial class list_mahasiswa
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
            btn_list = new Button();
            btn_validasi = new Button();
            btn_dashboard = new Button();
            navbar = new TableLayoutPanel();
            content = new Panel();
            dataGridView1 = new DataGridView();
            nama = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            nim = new DataGridViewTextBoxColumn();
            fakultas = new DataGridViewTextBoxColumn();
            upload = new DataGridViewTextBoxColumn();
            pilih = new DataGridViewButtonColumn();
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
            header.Anchor = AnchorStyles.None;
            header.BorderStyle = BorderStyle.FixedSingle;
            header.Controls.Add(logo);
            header.Controls.Add(label1);
            header.Location = new Point(1, 3);
            header.Name = "header";
            header.Size = new Size(1231, 115);
            header.TabIndex = 12;
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
            btn_validasi.Click += btn_validasi_Click;
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
            // content
            // 
            content.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            content.BorderStyle = BorderStyle.FixedSingle;
            content.Controls.Add(dataGridView1);
            content.Controls.Add(label_content);
            content.Location = new Point(347, 138);
            content.Name = "content";
            content.Size = new Size(890, 475);
            content.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.DarkOrange;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nama, email, nim, fakultas, upload, pilih });
            dataGridView1.Location = new Point(18, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(853, 180);
            dataGridView1.TabIndex = 1;
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
            // nim
            // 
            nim.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nim.HeaderText = "NIM";
            nim.MinimumWidth = 6;
            nim.Name = "nim";
            nim.ReadOnly = true;
            // 
            // fakultas
            // 
            fakultas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fakultas.HeaderText = "Fakultas";
            fakultas.MinimumWidth = 6;
            fakultas.Name = "fakultas";
            fakultas.ReadOnly = true;
            // 
            // upload
            // 
            upload.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            upload.HeaderText = "Tanggal Upload";
            upload.MinimumWidth = 6;
            upload.Name = "upload";
            upload.ReadOnly = true;
            // 
            // pilih
            // 
            pilih.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            pilih.HeaderText = "Pilih";
            pilih.MinimumWidth = 6;
            pilih.Name = "pilih";
            pilih.Resizable = DataGridViewTriState.True;
            pilih.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // label_content
            // 
            label_content.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_content.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label_content.Location = new Point(-1, -1);
            label_content.Name = "label_content";
            label_content.Size = new Size(886, 39);
            label_content.TabIndex = 0;
            label_content.Text = "List Mahasiswa";
            label_content.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // siderbar
            // 
            siderbar.Anchor = AnchorStyles.None;
            siderbar.BorderStyle = BorderStyle.FixedSingle;
            siderbar.Controls.Add(navbar);
            siderbar.Location = new Point(3, 138);
            siderbar.Name = "siderbar";
            siderbar.Size = new Size(335, 475);
            siderbar.TabIndex = 13;
            // 
            // list_mahasiswa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 616);
            Controls.Add(header);
            Controls.Add(content);
            Controls.Add(siderbar);
            Name = "list_mahasiswa";
            Text = "list_mahasiswa";
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
        private Button btn_list;
        private Button btn_validasi;
        private Button btn_dashboard;
        private TableLayoutPanel navbar;
        private Panel content;
        private Label label_content;
        private Panel siderbar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nama;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn nim;
        private DataGridViewTextBoxColumn fakultas;
        private DataGridViewTextBoxColumn upload;
        private DataGridViewButtonColumn pilih;
    }
}