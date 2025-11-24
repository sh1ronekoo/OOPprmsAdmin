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
            txtUsername.Location = new Point(83, 371);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(329, 27);
            txtUsername.TabIndex = 0;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(83, 517);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(329, 31);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkLabelCreateAccount
            // 
            linkLabelCreateAccount.AutoSize = true;
            linkLabelCreateAccount.Location = new Point(241, 572);
            linkLabelCreateAccount.Name = "linkLabelCreateAccount";
            linkLabelCreateAccount.Size = new Size(110, 20);
            linkLabelCreateAccount.TabIndex = 3;
            linkLabelCreateAccount.TabStop = true;
            linkLabelCreateAccount.Text = "Create Account";
            linkLabelCreateAccount.LinkClicked += linkLabelCreateAccount_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(395, 505);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 5;
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(82, 341);
            label3.Name = "label3";
            label3.Size = new Size(76, 17);
            label3.TabIndex = 7;
            label3.Text = "USERNAME";
            label3.Click += label3_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(83, 443);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(329, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(83, 421);
            label2.Name = "label2";
            label2.Size = new Size(75, 17);
            label2.TabIndex = 8;
            label2.Text = "PASSWORD";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.prms;
            pictureBox1.Location = new Point(26, -24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(443, 405);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(155, 284);
            label4.Name = "label4";
            label4.Size = new Size(170, 40);
            label4.TabIndex = 10;
            label4.Text = "Welcome Back!";
            // 
            // label5
            // 
            label5.Location = new Point(117, 572);
            label5.Name = "label5";
            label5.Size = new Size(151, 25);
            label5.TabIndex = 11;
            label5.Text = "Need an account?";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(499, 657);
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
            Margin = new Padding(3, 4, 3, 4);
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

