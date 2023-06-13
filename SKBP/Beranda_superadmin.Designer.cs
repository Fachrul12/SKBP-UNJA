namespace SKBP
{
    partial class Beranda_superadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Beranda_superadmin));
            header = new Panel();
            logo = new PictureBox();
            label1 = new Label();
            navbar = new TableLayoutPanel();
            btn_kelola = new Button();
            btn_petugas = new Button();
            btn_dashboard = new Button();
            siderbar = new Panel();
            content = new Panel();
            label2 = new Label();
            label_content = new Label();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            navbar.SuspendLayout();
            siderbar.SuspendLayout();
            content.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            header.BorderStyle = BorderStyle.FixedSingle;
            header.Controls.Add(logo);
            header.Controls.Add(label1);
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(1239, 115);
            header.TabIndex = 6;
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
            btn_kelola.Click += btn_update_Click;
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
            btn_petugas.Click += btn_upload_Click;
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
            // siderbar
            // 
            siderbar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            siderbar.BorderStyle = BorderStyle.FixedSingle;
            siderbar.Controls.Add(navbar);
            siderbar.Location = new Point(0, 129);
            siderbar.Name = "siderbar";
            siderbar.Size = new Size(335, 475);
            siderbar.TabIndex = 8;
            siderbar.Paint += siderbar_Paint;
            // 
            // content
            // 
            content.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            content.BorderStyle = BorderStyle.FixedSingle;
            content.Controls.Add(label2);
            content.Controls.Add(label_content);
            content.Location = new Point(341, 129);
            content.Name = "content";
            content.Size = new Size(886, 475);
            content.TabIndex = 9;
            content.Paint += content_Paint;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.Location = new Point(3, 49);
            label2.Name = "label2";
            label2.Padding = new Padding(5);
            label2.Size = new Size(878, 424);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // label_content
            // 
            label_content.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_content.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label_content.Location = new Point(3, 3);
            label_content.Name = "label_content";
            label_content.Size = new Size(878, 39);
            label_content.TabIndex = 0;
            label_content.Text = "Dashboard";
            label_content.TextAlign = ContentAlignment.MiddleCenter;
            label_content.Click += label_content_Click;
            // 
            // Beranda_superadmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 616);
            Controls.Add(content);
            Controls.Add(siderbar);
            Controls.Add(header);
            Name = "Beranda_superadmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Beranda_superadmin";
            WindowState = FormWindowState.Maximized;
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            navbar.ResumeLayout(false);
            siderbar.ResumeLayout(false);
            content.ResumeLayout(false);
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
        private Panel siderbar;
        private Panel content;
        private Label label2;
        private Label label_content;
    }
}