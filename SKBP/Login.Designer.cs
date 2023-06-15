namespace SKBP
{
    partial class Login
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
            tb_username = new TextBox();
            tb_password = new TextBox();
            btn_login = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tb_username
            // 
            tb_username.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tb_username.Location = new Point(27, 90);
            tb_username.Margin = new Padding(3, 2, 3, 2);
            tb_username.Name = "tb_username";
            tb_username.PlaceholderText = "Username";
            tb_username.Size = new Size(295, 27);
            tb_username.TabIndex = 0;
            tb_username.TextChanged += tb_username_TextChanged;
            // 
            // tb_password
            // 
            tb_password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tb_password.Location = new Point(27, 150);
            tb_password.Margin = new Padding(3, 2, 3, 2);
            tb_password.Name = "tb_password";
            tb_password.PlaceholderText = "Password";
            tb_password.Size = new Size(295, 27);
            tb_password.TabIndex = 1;
            tb_password.UseSystemPasswordChar = true;
            tb_password.TextChanged += tb_password_TextChanged;
            // 
            // btn_login
            // 
            btn_login.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btn_login.Location = new Point(65, 264);
            btn_login.Margin = new Padding(3, 2, 3, 2);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(214, 27);
            btn_login.TabIndex = 2;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.BackColor = Color.DarkOrange;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(489, 156);
            label1.Name = "label1";
            label1.Size = new Size(263, 44);
            label1.TabIndex = 3;
            label1.Text = "SKBP UNJA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AccessibleRole = AccessibleRole.Window;
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.DarkOrange;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tb_username);
            panel1.Controls.Add(btn_login);
            panel1.Controls.Add(tb_password);
            panel1.Location = new Point(446, 222);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 336);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(135, 21);
            label2.Name = "label2";
            label2.Size = new Size(77, 30);
            label2.TabIndex = 2;
            label2.Text = "LOGIN";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Login
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackgroundImage = Properties.Resources.perpustakaan;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1239, 616);
            Controls.Add(panel1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tb_username;
        private TextBox tb_password;
        private Button btn_login;
        private Label label1;
        private Panel panel1;
        private Label label2;
    }
}