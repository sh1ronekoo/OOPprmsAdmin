using System;
using System.Windows.Forms;

namespace admindash.Records_Dashboard
{
    public partial class CompleteAppointmentForm : Form
    {
        public string Diagnosis { get; private set; }
        public string Findings { get; private set; }
        public string Prescription { get; private set; }

        public CompleteAppointmentForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDiagnosis.Text))
            {
                MessageBox.Show("Diagnosis is required.");
                return;
            }

            Diagnosis = txtDiagnosis.Text.Trim();
            Findings = txtFindings.Text.Trim();
            Prescription = txtPrescription.Text.Trim();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}