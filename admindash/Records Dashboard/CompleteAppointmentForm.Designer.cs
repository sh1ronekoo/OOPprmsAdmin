namespace admindash.Records_Dashboard
{
    partial class CompleteAppointmentForm
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
            txtDiagnosis = new TextBox();
            label2 = new Label();
            txtFindings = new TextBox();
            label3 = new Label();
            txtPrescription = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Diagnosis";
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Location = new Point(10, 27);
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.Size = new Size(245, 23);
            txtDiagnosis.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 65);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 0;
            label2.Text = "Findings";
            // 
            // txtFindings
            // 
            txtFindings.Location = new Point(10, 83);
            txtFindings.Name = "txtFindings";
            txtFindings.Size = new Size(245, 23);
            txtFindings.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 138);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 0;
            label3.Text = "Prescription";
            // 
            // txtPrescription
            // 
            txtPrescription.Location = new Point(10, 156);
            txtPrescription.Multiline = true;
            txtPrescription.Name = "txtPrescription";
            txtPrescription.ScrollBars = ScrollBars.Vertical;
            txtPrescription.Size = new Size(245, 96);
            txtPrescription.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(10, 258);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(91, 258);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // CompleteAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 292);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtPrescription);
            Controls.Add(label3);
            Controls.Add(txtFindings);
            Controls.Add(label2);
            Controls.Add(txtDiagnosis);
            Controls.Add(label1);
            Name = "CompleteAppointmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CompleteAppointmentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDiagnosis;
        private Label label2;
        private TextBox txtFindings;
        private Label label3;
        private TextBox txtPrescription;
        private Button btnCancel;
        private Button btnSave;
    }
}