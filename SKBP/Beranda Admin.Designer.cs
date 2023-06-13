﻿namespace SKBP
{
    partial class Beranda_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Beranda_Admin));
            label1 = new Label();
            btn_list = new Button();
            btn_validasi = new Button();
            logo = new PictureBox();
            btn_dashboard = new Button();
            header = new Panel();
            navbar = new TableLayoutPanel();
            content = new Panel();
            label2 = new Label();
            label_content = new Label();
            siderbar = new Panel();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            header.SuspendLayout();
            navbar.SuspendLayout();
            content.SuspendLayout();
            siderbar.SuspendLayout();
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
            btn_validasi.Click += btn_validasi_Click;
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
            btn_dashboard.TabIndex = 1;
            btn_dashboard.Text = "Dashboard";
            btn_dashboard.UseVisualStyleBackColor = false;
            btn_dashboard.Click += btn_dashboard_Click;
            // 
            // header
            // 
            header.Anchor = AnchorStyles.None;
            header.BorderStyle = BorderStyle.FixedSingle;
            header.Controls.Add(logo);
            header.Controls.Add(label1);
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(1231, 115);
            header.TabIndex = 9;
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
            content.Anchor = AnchorStyles.None;
            content.BorderStyle = BorderStyle.FixedSingle;
            content.Controls.Add(label2);
            content.Controls.Add(label_content);
            content.Location = new Point(346, 135);
            content.Name = "content";
            content.Size = new Size(890, 475);
            content.TabIndex = 11;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.Location = new Point(3, 49);
            label2.Name = "label2";
            label2.Padding = new Padding(5);
            label2.Size = new Size(882, 422);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label_content
            // 
            label_content.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_content.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label_content.Location = new Point(-1, -1);
            label_content.Name = "label_content";
            label_content.Size = new Size(886, 39);
            label_content.TabIndex = 0;
            label_content.Text = "Dashboard";
            label_content.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // siderbar
            // 
            siderbar.Anchor = AnchorStyles.None;
            siderbar.BorderStyle = BorderStyle.FixedSingle;
            siderbar.Controls.Add(navbar);
            siderbar.Location = new Point(2, 135);
            siderbar.Name = "siderbar";
            siderbar.Size = new Size(335, 475);
            siderbar.TabIndex = 10;
            // 
            // Beranda_Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 616);
            Controls.Add(header);
            Controls.Add(content);
            Controls.Add(siderbar);
            Name = "Beranda_Admin";
            Text = "Beranda_Admin";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            header.ResumeLayout(false);
            header.PerformLayout();
            navbar.ResumeLayout(false);
            content.ResumeLayout(false);
            siderbar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btn_list;
        private Button btn_validasi;
        private PictureBox logo;
        private Button btn_dashboard;
        private Panel header;
        private TableLayoutPanel navbar;
        private Panel content;
        private Label label2;
        private Label label_content;
        private Panel siderbar;
    }
}