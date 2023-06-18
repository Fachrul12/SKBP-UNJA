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
            components = new System.ComponentModel.Container();
            header = new Panel();
            lbl_username = new Label();
            btn_logout = new Button();
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
            mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            bindingSource1 = new BindingSource(components);
            uploadpersyaratanBindingSource = new BindingSource(components);
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            navbar.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)view_riwayat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uploadpersyaratanBindingSource).BeginInit();
            SuspendLayout();
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
            header.Size = new Size(1237, 119);
            header.TabIndex = 11;
            // 
            // lbl_username
            // 
            lbl_username.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_username.Location = new Point(963, 45);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(116, 28);
            lbl_username.TabIndex = 13;
            lbl_username.Text = "Mahasiswa";
            // 
            // btn_logout
            // 
            btn_logout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_logout.BackColor = Color.Silver;
            btn_logout.Cursor = Cursors.Hand;
            btn_logout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_logout.Location = new Point(1085, 44);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(94, 29);
            btn_logout.TabIndex = 3;
            btn_logout.Text = "Log Out";
            btn_logout.UseVisualStyleBackColor = false;
            btn_logout.Click += btn_logout_Click;
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
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Location = new Point(0, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(335, 592);
            panel2.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = SystemColors.AppWorkspace;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(view_riwayat);
            panel3.Controls.Add(label_konten);
            panel3.Location = new Point(338, 121);
            panel3.Name = "panel3";
            panel3.Size = new Size(898, 592);
            panel3.TabIndex = 14;
            // 
            // view_riwayat
            // 
            view_riwayat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            view_riwayat.BackgroundColor = SystemColors.ButtonHighlight;
            view_riwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            view_riwayat.Location = new Point(12, 86);
            view_riwayat.Name = "view_riwayat";
            view_riwayat.RowHeadersWidth = 51;
            view_riwayat.RowTemplate.Height = 29;
            view_riwayat.Size = new Size(876, 194);
            view_riwayat.TabIndex = 2;
            view_riwayat.CellContentClick += view_riwayat_CellContentClick;
            // 
            // label_konten
            // 
            label_konten.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_konten.BackColor = Color.DarkOrange;
            label_konten.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label_konten.Location = new Point(1, 1);
            label_konten.Name = "label_konten";
            label_konten.Size = new Size(890, 39);
            label_konten.TabIndex = 1;
            label_konten.Text = "Riwayat";
            label_konten.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // mySqlDataAdapter1
            // 
            mySqlDataAdapter1.DeleteCommand = null;
            mySqlDataAdapter1.InsertCommand = null;
            mySqlDataAdapter1.SelectCommand = null;
            mySqlDataAdapter1.UpdateCommand = null;
            // 
            // uploadpersyaratanBindingSource
            // 
            uploadpersyaratanBindingSource.DataSource = typeof(Upload_persyaratan);
            // 
            // Riwayat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 722);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(header);
            Name = "Riwayat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Riwayat";
            WindowState = FormWindowState.Maximized;
            FormClosing += Riwayat_FormClosing;
            Load += Riwayat_Load;
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            navbar.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)view_riwayat).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)uploadpersyaratanBindingSource).EndInit();
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
        private Button btn_logout;
        private Label lbl_username;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private BindingSource bindingSource1;
        private BindingSource uploadpersyaratanBindingSource;
    }
}