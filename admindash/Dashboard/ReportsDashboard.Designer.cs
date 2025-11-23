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
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 528);
            panel1.TabIndex = 1;
            // 
            // btnExportPdf
            // 
            btnExportPdf.Location = new Point(644, 435);
            btnExportPdf.Name = "btnExportPdf";
            btnExportPdf.Size = new Size(94, 23);
            btnExportPdf.TabIndex = 1;
            btnExportPdf.Text = "Extract to PDF";
            btnExportPdf.UseVisualStyleBackColor = true;
            btnExportPdf.Click += btnExportPdf_Click;
            // 
            // lblDaily
            // 
            lblDaily.AutoSize = true;
            lblDaily.Font = new Font("Segoe UI", 11.5F);
            lblDaily.Location = new Point(436, 238);
            lblDaily.Name = "lblDaily";
            lblDaily.RightToLeft = RightToLeft.Yes;
            lblDaily.Size = new Size(19, 21);
            lblDaily.TabIndex = 0;
            lblDaily.Text = "0";
            // 
            // lblMonthly
            // 
            lblMonthly.AutoSize = true;
            lblMonthly.Font = new Font("Segoe UI", 11.5F);
            lblMonthly.Location = new Point(436, 281);
            lblMonthly.Name = "lblMonthly";
            lblMonthly.RightToLeft = RightToLeft.Yes;
            lblMonthly.Size = new Size(19, 21);
            lblMonthly.TabIndex = 0;
            lblMonthly.Text = "0";
            // 
            // lblWeekly
            // 
            lblWeekly.AutoSize = true;
            lblWeekly.Font = new Font("Segoe UI", 11.5F);
            lblWeekly.Location = new Point(436, 260);
            lblWeekly.Name = "lblWeekly";
            lblWeekly.RightToLeft = RightToLeft.Yes;
            lblWeekly.Size = new Size(19, 21);
            lblWeekly.TabIndex = 0;
            lblWeekly.Text = "0";
            // 
            // lblCancelled
            // 
            lblCancelled.AutoSize = true;
            lblCancelled.Font = new Font("Segoe UI", 11.25F);
            lblCancelled.Location = new Point(246, 347);
            lblCancelled.Name = "lblCancelled";
            lblCancelled.Size = new Size(17, 20);
            lblCancelled.TabIndex = 0;
            lblCancelled.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.5F);
            label13.Location = new Point(569, 238);
            label13.Name = "label13";
            label13.RightToLeft = RightToLeft.Yes;
            label13.Size = new Size(51, 21);
            label13.TabIndex = 0;
            label13.Text = "DAILY";
            label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11.5F);
            label15.Location = new Point(537, 280);
            label15.Name = "label15";
            label15.RightToLeft = RightToLeft.Yes;
            label15.Size = new Size(83, 21);
            label15.TabIndex = 0;
            label15.Text = "MONTHLY";
            label15.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.5F);
            label11.Location = new Point(554, 259);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.Yes;
            label11.Size = new Size(66, 21);
            label11.TabIndex = 0;
            label11.Text = "WEEKLY";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F);
            label9.Location = new Point(79, 347);
            label9.Name = "label9";
            label9.Size = new Size(89, 20);
            label9.TabIndex = 0;
            label9.Text = "CANCELLED";
            // 
            // lblDeclined
            // 
            lblDeclined.AutoSize = true;
            lblDeclined.Font = new Font("Segoe UI", 11.25F);
            lblDeclined.Location = new Point(246, 327);
            lblDeclined.Name = "lblDeclined";
            lblDeclined.Size = new Size(17, 20);
            lblDeclined.TabIndex = 0;
            lblDeclined.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(79, 327);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 0;
            label7.Text = "DECLINED";
            // 
            // lblAccepted
            // 
            lblAccepted.AutoSize = true;
            lblAccepted.Font = new Font("Segoe UI", 11.25F);
            lblAccepted.Location = new Point(246, 307);
            lblAccepted.Name = "lblAccepted";
            lblAccepted.Size = new Size(17, 20);
            lblAccepted.TabIndex = 0;
            lblAccepted.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(79, 307);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 0;
            label5.Text = "ACCEPTED";
            // 
            // lblCompleted
            // 
            lblCompleted.AutoSize = true;
            lblCompleted.Font = new Font("Segoe UI", 11.25F);
            lblCompleted.Location = new Point(246, 267);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Size = new Size(17, 20);
            lblCompleted.TabIndex = 0;
            lblCompleted.Text = "0";
            // 
            // lblPending
            // 
            lblPending.AutoSize = true;
            lblPending.Font = new Font("Segoe UI", 11.25F);
            lblPending.Location = new Point(246, 287);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(17, 20);
            lblPending.TabIndex = 0;
            lblPending.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F);
            label8.Location = new Point(79, 267);
            label8.Name = "label8";
            label8.Size = new Size(92, 20);
            label8.TabIndex = 0;
            label8.Text = "COMPLETED";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(79, 287);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 0;
            label3.Text = "PENDING";
            // 
            // lblTotalBookings
            // 
            lblTotalBookings.AutoSize = true;
            lblTotalBookings.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalBookings.Location = new Point(151, 180);
            lblTotalBookings.Name = "lblTotalBookings";
            lblTotalBookings.Size = new Size(39, 47);
            lblTotalBookings.TabIndex = 0;
            lblTotalBookings.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(53, 43);
            label2.Name = "label2";
            label2.Size = new Size(250, 32);
            label2.TabIndex = 0;
            label2.Text = "REPORTS OVERVIEW";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.Location = new Point(396, 155);
            label6.Name = "label6";
            label6.Size = new Size(224, 25);
            label6.TabIndex = 0;
            label6.Text = "PERIODIC BREAKDOWN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(80, 155);
            label4.Name = "label4";
            label4.Size = new Size(173, 25);
            label4.TabIndex = 0;
            label4.Text = "BOOKING STATUS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(104, 228);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 0;
            label1.Text = "TOTAL BOOKINGS";
            // 
            // ReportsDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 528);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
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