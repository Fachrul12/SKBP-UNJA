namespace SKBP
{
    partial class Riwayat
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
            sidebar = new Panel();
            siderbar = new Panel();
            navbar = new TableLayoutPanel();
            btn_update = new Button();
            btn_upload = new Button();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            button3 = new Button();
            button4 = new Button();
            btn_riwayat = new Button();
            btn_dashboard = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            view_riwayat = new DataGridView();
            label_konten = new Label();
            Periode = new DataGridViewTextBoxColumn();
            tanggal_lapor = new DataGridViewTextBoxColumn();
            tanggal_disetujui = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            aksi = new DataGridViewButtonColumn();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            navbar.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)view_riwayat).BeginInit();
            SuspendLayout();
            // 
            // header
            // 
            header.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            header.BorderStyle = BorderStyle.FixedSingle;
            header.Controls.Add(logo);
            header.Controls.Add(label1);
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(1237, 119);
            header.TabIndex = 11;
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
            // sidebar
            // 
            sidebar.BorderStyle = BorderStyle.FixedSingle;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(200, 100);
            sidebar.TabIndex = 0;
            // 
            // siderbar
            // 
            siderbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            siderbar.BorderStyle = BorderStyle.FixedSingle;
            siderbar.Location = new Point(0, 0);
            siderbar.Name = "siderbar";
            siderbar.Size = new Size(200, 100);
            siderbar.TabIndex = 0;
            // 
            // navbar
            // 
            navbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            navbar.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            navbar.ColumnCount = 1;
            navbar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            navbar.Controls.Add(btn_update, 0, 2);
            navbar.Location = new Point(0, 0);
            navbar.Name = "navbar";
            navbar.RowCount = 3;
            navbar.Size = new Size(200, 100);
            navbar.TabIndex = 0;
            // 
            // btn_update
            // 
            btn_update.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_update.BackColor = Color.DarkOrange;
            btn_update.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update.Location = new Point(4, 6);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(192, 94);
            btn_update.TabIndex = 2;
            btn_update.Text = "Update Persyaratan";
            btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_upload
            // 
            btn_upload.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_upload.BackColor = Color.DarkOrange;
            btn_upload.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_upload.Location = new Point(4, 5);
            btn_upload.Name = "btn_upload";
            btn_upload.Size = new Size(192, 94);
            btn_upload.TabIndex = 1;
            btn_upload.Text = "Upload Persyaratan";
            btn_upload.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(button1, 0, 2);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.DarkOrange;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(4, 6);
            button1.Name = "button1";
            button1.Size = new Size(192, 94);
            button1.TabIndex = 2;
            button1.Text = "Update Persyaratan";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.DarkOrange;
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(4, 5);
            button2.Name = "button2";
            button2.Size = new Size(192, 94);
            button2.TabIndex = 1;
            button2.Text = "Upload Persyaratan";
            button2.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(button3, 0, 2);
            tableLayoutPanel2.Controls.Add(button4, 0, 1);
            tableLayoutPanel2.Controls.Add(btn_riwayat, 0, 3);
            tableLayoutPanel2.Controls.Add(btn_dashboard, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.Size = new Size(327, 401);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.BackColor = Color.DarkOrange;
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(4, 206);
            button3.Name = "button3";
            button3.Size = new Size(319, 94);
            button3.TabIndex = 2;
            button3.Text = "Update Persyaratan";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.BackColor = Color.DarkOrange;
            button4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(4, 105);
            button4.Name = "button4";
            button4.Size = new Size(319, 94);
            button4.TabIndex = 1;
            button4.Text = "Upload Persyaratan";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btn_riwayat
            // 
            btn_riwayat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Location = new Point(0, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(335, 486);
            panel2.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(view_riwayat);
            panel3.Controls.Add(label_konten);
            panel3.Location = new Point(338, 121);
            panel3.Name = "panel3";
            panel3.Size = new Size(898, 486);
            panel3.TabIndex = 14;
            // 
            // view_riwayat
            // 
            view_riwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            view_riwayat.Columns.AddRange(new DataGridViewColumn[] { Periode, tanggal_lapor, tanggal_disetujui, status, aksi });
            view_riwayat.Location = new Point(12, 43);
            view_riwayat.Name = "view_riwayat";
            view_riwayat.RowHeadersWidth = 51;
            view_riwayat.RowTemplate.Height = 29;
            view_riwayat.Size = new Size(876, 194);
            view_riwayat.TabIndex = 2;
            // 
            // label_konten
            // 
            label_konten.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_konten.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label_konten.Location = new Point(1, 1);
            label_konten.Name = "label_konten";
            label_konten.Size = new Size(890, 39);
            label_konten.TabIndex = 1;
            label_konten.Text = "Riwayat";
            label_konten.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Periode
            // 
            Periode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Periode.HeaderText = "Periode";
            Periode.MinimumWidth = 6;
            Periode.Name = "Periode";
            Periode.ReadOnly = true;
            // 
            // tanggal_lapor
            // 
            tanggal_lapor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tanggal_lapor.HeaderText = "Tanggal Lapor";
            tanggal_lapor.MinimumWidth = 6;
            tanggal_lapor.Name = "tanggal_lapor";
            tanggal_lapor.ReadOnly = true;
            // 
            // tanggal_disetujui
            // 
            tanggal_disetujui.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tanggal_disetujui.HeaderText = "Tanggal Disetujui";
            tanggal_disetujui.MinimumWidth = 6;
            tanggal_disetujui.Name = "tanggal_disetujui";
            tanggal_disetujui.ReadOnly = true;
            // 
            // status
            // 
            status.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            status.HeaderText = "Status";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.ReadOnly = true;
            // 
            // aksi
            // 
            aksi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            aksi.HeaderText = "Aksi";
            aksi.MinimumWidth = 6;
            aksi.Name = "aksi";
            aksi.Resizable = DataGridViewTriState.True;
            aksi.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Riwayat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 616);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(header);
            Name = "Riwayat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Riwayat";
            WindowState = FormWindowState.Maximized;
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            navbar.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)view_riwayat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel header;
        private PictureBox logo;
        private Label label1;
        private Panel sidebar;
        private Panel siderbar;
        private TableLayoutPanel navbar;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button3;
        private Button button4;
        private Button btn_riwayat;
        private Button btn_dashboard;
        private Button btn_upload;
        private Button btn_update;
        private Panel panel2;
        private Panel panel3;
        private Label label_konten;
        private DataGridView view_riwayat;
        private DataGridViewTextBoxColumn Periode;
        private DataGridViewTextBoxColumn tanggal_lapor;
        private DataGridViewTextBoxColumn tanggal_disetujui;
        private DataGridViewTextBoxColumn status;
        private DataGridViewButtonColumn aksi;
    }
}