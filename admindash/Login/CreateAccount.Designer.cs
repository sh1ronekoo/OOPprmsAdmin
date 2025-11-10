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
            txtCreateUsername = new TextBox();
            txtCreatePassword = new TextBox();
            txtCreateConfirmPassword = new TextBox();
            btnCreateAccount = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtCreateUsername
            // 
            txtCreateUsername.Location = new Point(341, 127);
            txtCreateUsername.Name = "txtCreateUsername";
            txtCreateUsername.Size = new Size(100, 23);
            txtCreateUsername.TabIndex = 0;
            // 
            // txtCreatePassword
            // 
            txtCreatePassword.Location = new Point(341, 170);
            txtCreatePassword.Name = "txtCreatePassword";
            txtCreatePassword.Size = new Size(100, 23);
            txtCreatePassword.TabIndex = 1;
            // 
            // txtCreateConfirmPassword
            // 
            txtCreateConfirmPassword.Location = new Point(341, 214);
            txtCreateConfirmPassword.Name = "txtCreateConfirmPassword";
            txtCreateConfirmPassword.Size = new Size(100, 23);
            txtCreateConfirmPassword.TabIndex = 1;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(325, 243);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(132, 23);
            btnCreateAccount.TabIndex = 2;
            btnCreateAccount.Text = "CREATE ACCOUNT";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += this.btnCreateAccount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(341, 109);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 153);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(341, 196);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 5;
            label3.Text = "Confirm Password";
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCreateAccount);
            Controls.Add(txtCreateConfirmPassword);
            Controls.Add(txtCreatePassword);
            Controls.Add(txtCreateUsername);
            Name = "CreateAccount";
            Text = "CreateAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCreateUsername;
        private TextBox txtCreatePassword;
        private TextBox txtCreateConfirmPassword;
        private Button btnCreateAccount;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}