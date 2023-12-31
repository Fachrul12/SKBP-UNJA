﻿namespace SKBP
{
    partial class Beranda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Beranda));
            label1 = new Label();
            btn_upload = new Button();
            btn_update = new Button();
            btn_riwayat = new Button();
            logo = new PictureBox();
            btn_dashboard = new Button();
            header = new Panel();
            btn_logout = new Button();
            navbar = new TableLayoutPanel();
            siderbar = new Panel();
            content = new Panel();
            label2 = new Label();
            label_content = new Label();
            lbl_username = new Label();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            header.SuspendLayout();
            navbar.SuspendLayout();
            siderbar.SuspendLayout();
            content.SuspendLayout();
            SuspendLayout();
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
            // btn_upload
            // 
            btn_upload.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_upload.BackColor = Color.DarkOrange;
            btn_upload.Cursor = Cursors.Hand;
            btn_upload.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_upload.Location = new Point(4, 105);
            btn_upload.Name = "btn_upload";
            btn_upload.Size = new Size(319, 94);
            btn_upload.TabIndex = 2;
            btn_upload.Text = "Upload Persyaratan";
            btn_upload.UseVisualStyleBackColor = false;
            btn_upload.Click += btn_upload_Click;
            // 
            // btn_update
            // 
            btn_update.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_update.BackColor = Color.DarkOrange;
            btn_update.Cursor = Cursors.Hand;
            btn_update.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update.Location = new Point(4, 206);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(319, 94);
            btn_update.TabIndex = 3;
            btn_update.Text = "Update Persyaratan";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_riwayat
            // 
            btn_riwayat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_riwayat.BackColor = Color.DarkOrange;
            btn_riwayat.Cursor = Cursors.Hand;
            btn_riwayat.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_riwayat.Location = new Point(4, 307);
            btn_riwayat.Name = "btn_riwayat";
            btn_riwayat.Size = new Size(319, 94);
            btn_riwayat.TabIndex = 4;
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
            logo.Click += logo_Click;
            // 
            // btn_dashboard
            // 
            btn_dashboard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_dashboard.BackColor = Color.DarkOrange;
            btn_dashboard.Cursor = Cursors.Hand;
            btn_dashboard.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_dashboard.Location = new Point(4, 4);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Size = new Size(319, 94);
            btn_dashboard.TabIndex = 1;
            btn_dashboard.Text = "Dashboard";
            btn_dashboard.UseVisualStyleBackColor = false;
            btn_dashboard.Click += btn_dashboard_Click;
            // 
            // header
            // 
            header.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            header.BackColor = SystemColors.AppWorkspace;
            header.BorderStyle = BorderStyle.FixedSingle;
            header.Controls.Add(lbl_username);
            header.Controls.Add(btn_logout);
            header.Controls.Add(logo);
            header.Controls.Add(label1);
            header.Location = new Point(4, -4);
            header.Name = "header";
            header.Size = new Size(1266, 119);
            header.TabIndex = 5;
            header.Paint += header_Paint;
            // 
            // btn_logout
            // 
            btn_logout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_logout.BackColor = Color.Silver;
            btn_logout.Cursor = Cursors.Hand;
            btn_logout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_logout.Location = new Point(1150, 44);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(94, 29);
            btn_logout.TabIndex = 2;
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
            navbar.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            navbar.Size = new Size(327, 403);
            navbar.TabIndex = 6;
            navbar.Paint += navbar_Paint;
            // 
            // siderbar
            // 
            siderbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            siderbar.BackColor = SystemColors.AppWorkspace;
            siderbar.BorderStyle = BorderStyle.FixedSingle;
            siderbar.Controls.Add(navbar);
            siderbar.Location = new Point(0, 121);
            siderbar.Name = "siderbar";
            siderbar.Size = new Size(335, 488);
            siderbar.TabIndex = 7;
            siderbar.Paint += siderbar_Paint;
            // 
            // content
            // 
            content.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            content.BackColor = SystemColors.AppWorkspace;
            content.BorderStyle = BorderStyle.FixedSingle;
            content.Controls.Add(label2);
            content.Controls.Add(label_content);
            content.Location = new Point(341, 121);
            content.Name = "content";
            content.Size = new Size(928, 488);
            content.TabIndex = 8;
            content.Paint += content_Paint;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = SystemColors.AppWorkspace;
            label2.Location = new Point(0, 46);
            label2.Name = "label2";
            label2.Padding = new Padding(5);
            label2.Size = new Size(924, 441);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // label_content
            // 
            label_content.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_content.BackColor = Color.DarkOrange;
            label_content.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label_content.Location = new Point(-4, -1);
            label_content.Name = "label_content";
            label_content.Size = new Size(928, 47);
            label_content.TabIndex = 0;
            label_content.Text = "Dashboard";
            label_content.TextAlign = ContentAlignment.MiddleCenter;
            label_content.Click += lbl_dashboard_Click;
            // 
            // lbl_username
            // 
            lbl_username.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_username.Location = new Point(1028, 41);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(116, 28);
            lbl_username.TabIndex = 3;
            lbl_username.Text = "Mahasiswa";
            // 
            // Beranda
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.perpustakaan;
            ClientSize = new Size(1270, 614);
            Controls.Add(content);
            Controls.Add(siderbar);
            Controls.Add(header);
            Name = "Beranda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Beranda";
            WindowState = FormWindowState.Maximized;
            Load += Beranda_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            header.ResumeLayout(false);
            header.PerformLayout();
            navbar.ResumeLayout(false);
            siderbar.ResumeLayout(false);
            content.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btn_upload;
        private Button btn_update;
        private Button btn_riwayat;
        private Button btn_dashboard;
        private PictureBox logo;
        private Panel header;
        private TableLayoutPanel navbar;
        private Panel siderbar;
        private Panel content;
        private Label label_content;
        private Label label2;
        private Button btn_logout;
        private Label lbl_username;
    }
}