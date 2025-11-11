namespace admindash.Dashboard
{
    partial class RecordsDashboard
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
            btnCancelled = new Panel();
            panel2 = new Panel();
            btnDeclined = new Button();
            btnAccepted = new Button();
            btnCompleted = new Button();
            button5 = new Button();
            btnAll = new Button();
            btnCancelled.SuspendLayout();
            SuspendLayout();
            // 
            // btnCancelled
            // 
            btnCancelled.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCancelled.BackColor = SystemColors.Control;
            btnCancelled.Controls.Add(panel2);
            btnCancelled.Controls.Add(btnDeclined);
            btnCancelled.Controls.Add(btnAccepted);
            btnCancelled.Controls.Add(btnCompleted);
            btnCancelled.Controls.Add(button5);
            btnCancelled.Controls.Add(btnAll);
            btnCancelled.Location = new Point(0, 0);
            btnCancelled.Name = "btnCancelled";
            btnCancelled.Size = new Size(750, 528);
            btnCancelled.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Location = new Point(36, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(702, 427);
            panel2.TabIndex = 2;
            // 
            // btnDeclined
            // 
            btnDeclined.Location = new Point(279, 34);
            btnDeclined.Name = "btnDeclined";
            btnDeclined.Size = new Size(75, 23);
            btnDeclined.TabIndex = 1;
            btnDeclined.Text = "Declined";
            btnDeclined.UseVisualStyleBackColor = true;
            btnDeclined.Click += btnDeclined_Click;
            // 
            // btnAccepted
            // 
            btnAccepted.Location = new Point(198, 34);
            btnAccepted.Name = "btnAccepted";
            btnAccepted.Size = new Size(75, 23);
            btnAccepted.TabIndex = 1;
            btnAccepted.Text = "Accepted";
            btnAccepted.UseVisualStyleBackColor = true;
            btnAccepted.Click += btnAccepted_Click;
            // 
            // btnCompleted
            // 
            btnCompleted.Location = new Point(117, 34);
            btnCompleted.Name = "btnCompleted";
            btnCompleted.Size = new Size(75, 23);
            btnCompleted.TabIndex = 1;
            btnCompleted.Text = "Completed";
            btnCompleted.UseVisualStyleBackColor = true;
            btnCompleted.Click += btnCompleted_Click;
            // 
            // button5
            // 
            button5.Location = new Point(360, 34);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 1;
            button5.Text = "Cancelled";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnCancelled_Click;
            // 
            // btnAll
            // 
            btnAll.Location = new Point(36, 34);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(75, 23);
            btnAll.TabIndex = 1;
            btnAll.Text = "All";
            btnAll.UseVisualStyleBackColor = true;
            btnAll.Click += btnAll_Click;
            // 
            // RecordsDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 528);
            Controls.Add(btnCancelled);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RecordsDashboard";
            Text = "RecordsDashboard";
            btnCancelled.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel btnCancelled;
        private Button btnDeclined;
        private Button btnAccepted;
        private Button btnCompleted;
        private Button button5;
        private Button btnAll;
        private Panel panel2;
    }
}