using admindash.Core;
using admindash.Records_Dashboard;
using System;
using System.Windows.Forms;

namespace admindash.Dashboard
{
    public partial class RecordsDashboard : Form
    {
        private Form _activeForm = null; // Tracks the current child form

        public RecordsDashboard()
        {
            InitializeComponent();
            this.Load += RecordsDashboard_Load;
        }

        private void RecordsDashboard_Load(object sender, EventArgs e)
        {
            // Default load
            LoadFormInPanel(new AllApp());
        }

        private void LoadFormInPanel(Form form)
        {
            panel2.Controls.Clear();
            _activeForm = form; // Capture reference

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel2.Controls.Add(form);
            panel2.Tag = form;
            form.Show();
        }

        // --- NEW DELETE BUTTON LOGIC ---
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_activeForm is IRecordView recordView)
            {
                int idToDelete = recordView.GetSelectedAppointmentId();

                if (idToDelete == -1)
                {
                    MessageBox.Show("Please select an appointment to delete.");
                    return;
                }

                var result = MessageBox.Show(
                    $"Are you sure you want to PERMANENTLY DELETE Appointment #{idToDelete}?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    AppointmentService service = new AppointmentService();
                    if (service.DeleteAppointment(idToDelete))
                    {
                        MessageBox.Show("Record deleted successfully.");
                        recordView.RefreshData(); // Refresh the child form
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete record.");
                    }
                }
            }
            else
            {
                MessageBox.Show("No record list is currently active.");
            }
        }

        // Navigation Buttons
        private void btnAll_Click(object sender, EventArgs e) => LoadFormInPanel(new AllApp());
        private void btnAccepted_Click(object sender, EventArgs e) => LoadFormInPanel(new AcceptedApp());
        private void btnCompleted_Click(object sender, EventArgs e) => LoadFormInPanel(new CompletedApp());
        private void btnCancelled_Click(object sender, EventArgs e) => LoadFormInPanel(new CancelledApp());
        private void btnDeclined_Click(object sender, EventArgs e) => LoadFormInPanel(new DeclinedApp());

        private void listViewRecords_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}