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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            txtCreateUsername = new TextBox();
            txtCreatePassword = new TextBox();
            txtCreateConfirmPassword = new TextBox();


            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtCreateUsername
            // 
            txtCreateUsername.Location = new Point(341, 127);
            txtCreateUsername.Location = new Point(46, 216);
            txtCreateUsername.Margin = new Padding(3, 4, 3, 4);
            txtCreateUsername.Name = "txtCreateUsername";
            txtCreateUsername.Size = new Size(100, 23);
            txtCreateUsername.Size = new Size(294, 27);
            txtCreateUsername.TabIndex = 0;
            // 
            // txtCreatePassword
            // 
            txtCreatePassword.Location = new Point(341, 170);
            txtCreatePassword.Location = new Point(46, 284);
            txtCreatePassword.Margin = new Padding(3, 4, 3, 4);
            txtCreatePassword.Name = "txtCreatePassword";
            txtCreatePassword.Size = new Size(100, 23);
            txtCreatePassword.Size = new Size(294, 27);
            txtCreatePassword.TabIndex = 1;
            // 
            // txtCreateConfirmPassword
            // 
            txtCreateConfirmPassword.Location = new Point(341, 214);
            txtCreateConfirmPassword.Location = new Point(47, 361);
            txtCreateConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            txtCreateConfirmPassword.Name = "txtCreateConfirmPassword";
            txtCreateConfirmPassword.Size = new Size(100, 23);
            txtCreateConfirmPassword.Size = new Size(293, 27);
            txtCreateConfirmPassword.TabIndex = 1;
            // 
            // btnCreateAccount
            // 
            
           
            btnCreateAccount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAccount.Location = new Point(113, 429);
            btnCreateAccount.Margin = new Padding(3, 4, 3, 4);
            btnCreateAccount.Name = "btnCreateAccount";
           
            btnCreateAccount.Size = new Size(151, 31);
            btnCreateAccount.TabIndex = 2;
            btnCreateAccount.Text = "CREATE ACCOUNT";
            
            
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(341, 109);
            label1.Location = new Point(46, 192);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(341, 153);
            label2.Location = new Point(47, 260);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(341, 196);
            label3.Location = new Point(46, 337);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.Size = new Size(127, 20);
            label3.TabIndex = 5;
            label3.Text = "Confirm Password";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(366, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 600);
            panel1.TabIndex = 6;
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
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientInactiveCaption;
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 573);
            panel3.Name = "panel3";
            panel3.Size = new Size(366, 27);
            panel3.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientInactiveCaption;
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 43);
            panel4.Name = "panel4";
            panel4.Size = new Size(28, 530);
            panel4.TabIndex = 9;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.GradientInactiveCaption;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 445);
            label4.Name = "label4";
            label4.Size = new Size(230, 90);
            label4.TabIndex = 10;
            label4.Text = "Every detail matters.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-65, -70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(451, 476);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(34, 68);
            label5.Name = "label5";
            label5.Size = new Size(230, 90);
            label5.TabIndex = 12;
            label5.Text = "Create Your Acoount";
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(682, 600);
            Controls.Add(label5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);


            Controls.Add(txtCreateConfirmPassword);
            Controls.Add(txtCreatePassword);
            Controls.Add(txtCreateUsername);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreateAccount";
            Text = "CreateAccount";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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

       
        
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
    }
}