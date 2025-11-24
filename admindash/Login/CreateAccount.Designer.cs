namespace admindash
{
    partial class CreateAccount
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
            txtCreatePassword = new TextBox();
            txtCreateConfirmPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            txtCreateUsername = new TextBox();
            label4 = new Label();
            btnCreateAccount = new Button();
            SuspendLayout();
            // 
            // txtCreatePassword
            // 
            txtCreatePassword.Location = new Point(46, 284);
            txtCreatePassword.Margin = new Padding(3, 4, 3, 4);
            txtCreatePassword.Name = "txtCreatePassword";
            txtCreatePassword.Size = new Size(294, 27);
            txtCreatePassword.TabIndex = 1;
            txtCreatePassword.UseSystemPasswordChar = true;
            // 
            // txtCreateConfirmPassword
            // 
            txtCreateConfirmPassword.Location = new Point(46, 352);
            txtCreateConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            txtCreateConfirmPassword.Name = "txtCreateConfirmPassword";
            txtCreateConfirmPassword.Size = new Size(293, 27);
            txtCreateConfirmPassword.TabIndex = 2;
            txtCreateConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 192);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 260);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(366, 43);
            panel2.TabIndex = 7;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(34, 68);
            label5.Name = "label5";
            label5.Size = new Size(230, 91);
            label5.TabIndex = 12;
            label5.Text = "Create Your Acount";
            label5.Click += label5_Click;
            // 
            // txtCreateUsername
            // 
            txtCreateUsername.Location = new Point(46, 216);
            txtCreateUsername.Margin = new Padding(3, 4, 3, 4);
            txtCreateUsername.Name = "txtCreateUsername";
            txtCreateUsername.Size = new Size(294, 27);
            txtCreateUsername.TabIndex = 0;
            txtCreateUsername.TextChanged += txtCreateUsername_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 328);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 4;
            label4.Text = "Confirm Password";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(137, 416);
            btnCreateAccount.Margin = new Padding(3, 4, 3, 4);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(115, 31);
            btnCreateAccount.TabIndex = 3;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(378, 497);
            Controls.Add(btnCreateAccount);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCreateConfirmPassword);
            Controls.Add(txtCreateUsername);
            Controls.Add(txtCreatePassword);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreateAccount";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCreatePassword;
        private TextBox txtCreateConfirmPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Label label5;
        private TextBox txtCreateUsername;
        private Label label4;
        private Button btnCreateAccount;
    }
}