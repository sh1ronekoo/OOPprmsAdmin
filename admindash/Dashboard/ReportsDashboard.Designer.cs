namespace admindash.Dashboard
{
    partial class ReportsDashboard
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
            btnExportPdf = new Button();
            lblDaily = new Label();
            lblMonthly = new Label();
            lblWeekly = new Label();
            lblCancelled = new Label();
            label13 = new Label();
            label15 = new Label();
            label11 = new Label();
            label9 = new Label();
            lblDeclined = new Label();
            label7 = new Label();
            lblAccepted = new Label();
            label5 = new Label();
            lblCompleted = new Label();
            lblPending = new Label();
            label8 = new Label();
            label3 = new Label();
            lblTotalBookings = new Label();
            label2 = new Label();
            label6 = new Label();
            label4 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(btnExportPdf);
            panel1.Controls.Add(lblDaily);
            panel1.Controls.Add(lblMonthly);
            panel1.Controls.Add(lblWeekly);
            panel1.Controls.Add(lblCancelled);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(lblDeclined);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblAccepted);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lblCompleted);
            panel1.Controls.Add(lblPending);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblTotalBookings);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(857, 704);
            panel1.TabIndex = 1;
            // 
            // btnExportPdf
            // 
            btnExportPdf.Location = new Point(650, 592);
            btnExportPdf.Margin = new Padding(3, 4, 3, 4);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(152, 31);
            btnExportPdf.TabIndex = 1;
            btnExportPdf.Text = "Extract to CSV";
            btnExportPdf.UseVisualStyleBackColor = true;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // lblDaily
            // 
            lblDaily.AutoSize = true;
            lblDaily.Font = new Font("Segoe UI", 11.5F);
            lblDaily.Location = new Point(498, 317);
            lblDaily.Name = "lblDaily";
            lblDaily.RightToLeft = RightToLeft.Yes;
            lblDaily.Size = new Size(23, 28);
            lblDaily.TabIndex = 0;
            lblDaily.Text = "0";
            // 
            // lblMonthly
            // 
            lblMonthly.AutoSize = true;
            lblMonthly.Font = new Font("Segoe UI", 11.5F);
            lblMonthly.Location = new Point(498, 375);
            lblMonthly.Name = "lblMonthly";
            lblMonthly.RightToLeft = RightToLeft.Yes;
            lblMonthly.Size = new Size(23, 28);
            lblMonthly.TabIndex = 0;
            lblMonthly.Text = "0";
            // 
            // lblWeekly
            // 
            lblWeekly.AutoSize = true;
            lblWeekly.Font = new Font("Segoe UI", 11.5F);
            lblWeekly.Location = new Point(498, 347);
            lblWeekly.Name = "lblWeekly";
            lblWeekly.RightToLeft = RightToLeft.Yes;
            lblWeekly.Size = new Size(23, 28);
            lblWeekly.TabIndex = 0;
            lblWeekly.Text = "0";
            // 
            // lblCancelled
            // 
            lblCancelled.AutoSize = true;
            lblCancelled.Font = new Font("Segoe UI", 11.25F);
            lblCancelled.Location = new Point(281, 463);
            lblCancelled.Name = "lblCancelled";
            lblCancelled.Size = new Size(22, 25);
            lblCancelled.TabIndex = 0;
            lblCancelled.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.5F);
            label13.Location = new Point(650, 317);
            label13.Name = "label13";
            label13.RightToLeft = RightToLeft.Yes;
            label13.Size = new Size(63, 28);
            label13.TabIndex = 0;
            label13.Text = "DAILY";
            label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11.5F);
            label15.Location = new Point(614, 373);
            label15.Name = "label15";
            label15.RightToLeft = RightToLeft.Yes;
            label15.Size = new Size(103, 28);
            label15.TabIndex = 0;
            label15.Text = "MONTHLY";
            label15.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.5F);
            label11.Location = new Point(633, 345);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.Yes;
            label11.Size = new Size(82, 28);
            label11.TabIndex = 0;
            label11.Text = "WEEKLY";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F);
            label9.Location = new Point(90, 463);
            label9.Name = "label9";
            label9.Size = new Size(113, 25);
            label9.TabIndex = 0;
            label9.Text = "CANCELLED";
            // 
            // lblDeclined
            // 
            lblDeclined.AutoSize = true;
            lblDeclined.Font = new Font("Segoe UI", 11.25F);
            lblDeclined.Location = new Point(281, 436);
            lblDeclined.Name = "lblDeclined";
            lblDeclined.Size = new Size(22, 25);
            lblDeclined.TabIndex = 0;
            lblDeclined.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(90, 436);
            label7.Name = "label7";
            label7.Size = new Size(98, 25);
            label7.TabIndex = 0;
            label7.Text = "DECLINED";
            // 
            // lblAccepted
            // 
            lblAccepted.AutoSize = true;
            lblAccepted.Font = new Font("Segoe UI", 11.25F);
            lblAccepted.Location = new Point(281, 409);
            lblAccepted.Name = "lblAccepted";
            lblAccepted.Size = new Size(22, 25);
            lblAccepted.TabIndex = 0;
            lblAccepted.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(90, 409);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 0;
            label5.Text = "ACCEPTED";
            // 
            // lblCompleted
            // 
            lblCompleted.AutoSize = true;
            lblCompleted.Font = new Font("Segoe UI", 11.25F);
            lblCompleted.Location = new Point(281, 356);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Size = new Size(22, 25);
            lblCompleted.TabIndex = 0;
            lblCompleted.Text = "0";
            // 
            // lblPending
            // 
            lblPending.AutoSize = true;
            lblPending.Font = new Font("Segoe UI", 11.25F);
            lblPending.Location = new Point(281, 383);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(22, 25);
            lblPending.TabIndex = 0;
            lblPending.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F);
            label8.Location = new Point(90, 356);
            label8.Name = "label8";
            label8.Size = new Size(117, 25);
            label8.TabIndex = 0;
            label8.Text = "COMPLETED";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(90, 383);
            label3.Name = "label3";
            label3.Size = new Size(92, 25);
            label3.TabIndex = 0;
            label3.Text = "PENDING";
            // 
            // lblTotalBookings
            // 
            lblTotalBookings.AutoSize = true;
            lblTotalBookings.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalBookings.Location = new Point(173, 240);
            lblTotalBookings.Name = "lblTotalBookings";
            lblTotalBookings.Size = new Size(49, 60);
            lblTotalBookings.TabIndex = 0;
            lblTotalBookings.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(61, 57);
            label2.Name = "label2";
            label2.Size = new Size(313, 41);
            label2.TabIndex = 0;
            label2.Text = "REPORTS OVERVIEW";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.Location = new Point(453, 207);
            label6.Name = "label6";
            label6.Size = new Size(288, 32);
            label6.TabIndex = 0;
            label6.Text = "PERIODIC BREAKDOWN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(91, 207);
            label4.Name = "label4";
            label4.Size = new Size(216, 32);
            label4.TabIndex = 0;
            label4.Text = "BOOKING STATUS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(119, 304);
            label1.Name = "label1";
            label1.Size = new Size(175, 28);
            label1.TabIndex = 0;
            label1.Text = "TOTAL BOOKINGS";
            // 
            // ReportsDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 704);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReportsDashboard";
            Text = "ReportsDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTotalBookings;
        private Label label1;
        private Label lblDaily;
        private Label lblMonthly;
        private Label lblWeekly;
        private Label lblCancelled;
        private Label label13;
        private Label label15;
        private Label label11;
        private Label label9;
        private Label lblDeclined;
        private Label label7;
        private Label lblAccepted;
        private Label label5;
        private Label lblPending;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label6;
        private Label lblCompleted;
        private Label label8;
        private Button btnExportPdf;
    }
}