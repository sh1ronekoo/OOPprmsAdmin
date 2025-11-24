namespace admindash
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
            txtUsername = new TextBox();
            btnLogin = new Button();
            linkLabelCreateAccount = new LinkLabel();
            label1 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(73, 278);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(288, 23);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(73, 388);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(288, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkLabelCreateAccount
            // 
            linkLabelCreateAccount.AutoSize = true;
            linkLabelCreateAccount.Location = new Point(211, 429);
            linkLabelCreateAccount.Name = "linkLabelCreateAccount";
            linkLabelCreateAccount.Size = new Size(89, 15);
            linkLabelCreateAccount.TabIndex = 3;
            linkLabelCreateAccount.TabStop = true;
            linkLabelCreateAccount.Text = "Create Account";
            linkLabelCreateAccount.LinkClicked += linkLabelCreateAccount_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(346, 379);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 5;
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(72, 256);
            label3.Name = "label3";
            label3.Size = new Size(65, 13);
            label3.TabIndex = 7;
            label3.Text = "USERNAME";
            label3.Click += label3_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(73, 332);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(288, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 316);
            label2.Name = "label2";
            label2.Size = new Size(66, 13);
            label2.TabIndex = 8;
            label2.Text = "PASSWORD";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.prms;
            pictureBox1.Location = new Point(22, -60);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(388, 304);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(136, 194);
            label4.Name = "label4";
            label4.Size = new Size(149, 30);
            label4.TabIndex = 10;
            label4.Text = "Welcome Back!";
            // 
            // label5
            // 
            label5.Location = new Point(102, 429);
            label5.Name = "label5";
            label5.Size = new Size(132, 19);
            label5.TabIndex = 11;
            label5.Text = "Need an account?";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(437, 493);
            Controls.Add(label4);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(linkLabelCreateAccount);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsername;
        private Button btnLogin;
        private LinkLabel linkLabelCreateAccount;
        private Label label1;
        private Label label3;
        private TextBox txtPassword;
        private Label label2;
        private static Image prms;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
    }
}

