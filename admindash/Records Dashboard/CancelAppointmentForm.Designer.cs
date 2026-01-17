namespace admindash.Records_Dashboard
{
    partial class CancelAppointmentForm
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
            label1 = new Label();
            txtReason = new TextBox();
            btnCancel = new Button();
            btnConfirm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 0;
            label1.Text = "Reason for Cancellation:";
            // 
            // txtReason
            // 
            txtReason.Location = new Point(12, 27);
            txtReason.Multiline = true;
            txtReason.Name = "txtReason";
            txtReason.ScrollBars = ScrollBars.Vertical;
            txtReason.Size = new Size(245, 96);
            txtReason.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 129);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(93, 129);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(75, 23);
            btnConfirm.TabIndex = 2;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // CancelAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 161);
            Controls.Add(btnConfirm);
            Controls.Add(btnCancel);
            Controls.Add(txtReason);
            Controls.Add(label1);
            Name = "CancelAppointmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CancelAppointmentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtReason;
        private Button btnCancel;
        private Button btnConfirm;
    }
}