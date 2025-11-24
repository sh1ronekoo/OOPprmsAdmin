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
            panel1 = new Panel();
            panel2 = new Panel();
            btnDeclined = new Button();
            btnAccepted = new Button();
            btnCompleted = new Button();
            btnDelete = new Button();
            btnCancelled = new Button();
            btnAll = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnDeclined);
            panel1.Controls.Add(btnAccepted);
            panel1.Controls.Add(btnCompleted);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnCancelled);
            panel1.Controls.Add(btnAll);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(869, 505);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Location = new Point(36, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(798, 427);
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
            // btnDelete
            // 
            btnDelete.Location = new Point(759, 34);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancelled
            // 
            btnCancelled.Location = new Point(360, 34);
            btnCancelled.Name = "btnCancelled";
            btnCancelled.Size = new Size(75, 23);
            btnCancelled.TabIndex = 1;
            btnCancelled.Text = "Cancelled";
            btnCancelled.UseVisualStyleBackColor = true;
            btnCancelled.Click += btnCancelled_Click;
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
            ClientSize = new Size(866, 502);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RecordsDashboard";
            Text = "RecordsDashboard";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnDeclined;
        private Button btnAccepted;
        private Button btnCompleted;
        private Button btnCancelled;
        private Button btnAll;
        private Panel panel2;
        private Button btnDelete;
    }
}