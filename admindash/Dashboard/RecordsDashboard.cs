using admindash.Core;
using admindash.Records_Dashboard;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace admindash.Dashboard
{
    public partial class RecordsDashboard : Form
    {
        private Form _activeForm = null; // Tracks the current child form

        public RecordsDashboard()
        {
            InitializeComponent();
            this.Load += RecordsDashboard_Load;
            txtSearch.TextChanged += txtSearch_TextChanged;
        }

        private void RecordsDashboard_Load(object sender, EventArgs e)
        {
            cmbFilter.Items.AddRange(new string[]
            {
        "All",
        "Accepted",
        "Completed",
        "Cancelled",
        "Declined"
            });

            cmbFilter.SelectedIndex = 0; // Default = All
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

        private void listViewRecords_SelectedIndexChanged(object sender, EventArgs e) { }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbFilter.SelectedItem.ToString())
            {
                case "All":
                    LoadFormInPanel(new AllApp());
                    break;

                case "Accepted":
                    LoadFormInPanel(new AcceptedApp());
                    break;

                case "Completed":
                    LoadFormInPanel(new CompletedApp());
                    break;

                case "Cancelled":
                    LoadFormInPanel(new CancelledApp());
                    break;

                case "Declined":
                    LoadFormInPanel(new DeclinedApp());
                    break;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_activeForm is IRecordView recordView)
            {
                string keyword = txtSearch.Text.Trim();

                if (string.IsNullOrWhiteSpace(keyword))
                    recordView.RefreshData();
                else
                    recordView.Search(keyword);
            }
        }

    }
}