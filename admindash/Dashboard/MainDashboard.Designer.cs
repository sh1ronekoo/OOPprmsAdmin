namespace admindash.Dashboard
{
    partial class MainDashboard
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
            listViewAppointments = new ListView();
            btnDeclineAppointment = new Button();
            btnAcceptAppointment = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(listViewAppointments);
            panel1.Controls.Add(btnDeclineAppointment);
            panel1.Controls.Add(btnAcceptAppointment);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(755, 542);
            panel1.TabIndex = 0;
            // 
            // listViewAppointments
            // 
            listViewAppointments.Location = new Point(38, 42);
            listViewAppointments.Name = "listViewAppointments";
            listViewAppointments.Size = new Size(587, 333);
            listViewAppointments.TabIndex = 2;
            listViewAppointments.UseCompatibleStateImageBehavior = false;
            listViewAppointments.SelectedIndexChanged += listViewAppointments_SelectedIndexChanged;
            // 
            // btnDeclineAppointment
            // 
            btnDeclineAppointment.Location = new Point(119, 426);
            btnDeclineAppointment.Name = "btnDeclineAppointment";
            btnDeclineAppointment.Size = new Size(75, 23);
            btnDeclineAppointment.TabIndex = 1;
            btnDeclineAppointment.Text = "Decline";
            btnDeclineAppointment.UseVisualStyleBackColor = true;
            btnDeclineAppointment.Click += btnDeclineAppointment_Click;
            // 
            // btnAcceptAppointment
            // 
            btnAcceptAppointment.Location = new Point(38, 426);
            btnAcceptAppointment.Name = "btnAcceptAppointment";
            btnAcceptAppointment.Size = new Size(75, 23);
            btnAcceptAppointment.TabIndex = 1;
            btnAcceptAppointment.Text = "Accept";
            btnAcceptAppointment.UseVisualStyleBackColor = true;
            btnAcceptAppointment.Click += btnAcceptAppointment_Click;
            // 
            // MainDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 528);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainDashboard";
            Text = "MainDashboard";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnDeclineAppointment;
        private Button btnAcceptAppointment;
        private ListView listViewAppointments;
    }
}