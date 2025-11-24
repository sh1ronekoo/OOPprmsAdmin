using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using admindash.Core;

namespace admindash.Records_Dashboard
{
    public partial class AcceptedApp : Form, IRecordView
    {
        private int selectedAppointmentId = -1;

        public AcceptedApp()
        {
            InitializeComponent();
            this.Load += AcceptedApp_Load;
            listViewAccepted.SelectedIndexChanged += listViewAccepted_SelectedIndexChanged;
        }

        // Interface Implementation
        public int GetSelectedAppointmentId() => selectedAppointmentId;
        public void RefreshData() => LoadAcceptedAppointments();

        private void AcceptedApp_Load(object sender, EventArgs e)
        {
            listViewAccepted.View = View.Details;
            listViewAccepted.FullRowSelect = true;
            listViewAccepted.GridLines = true;

            listViewAccepted.Columns.Clear();
            listViewAccepted.Columns.Add("Appointment No.", 120);
            listViewAccepted.Columns.Add("Patient Name", 150);
            listViewAccepted.Columns.Add("Appointment Date & Time", 200);
            listViewAccepted.Columns.Add("Status", 120);
            listViewAccepted.Columns.Add("Gender", 80);
            listViewAccepted.Columns.Add("Age", 50);
            listViewAccepted.Columns.Add("DOB", 100);
            listViewAccepted.Columns.Add("Phone No.", 120);
            listViewAccepted.Columns.Add("Email", 120);
            listViewAccepted.Columns.Add("Medication", 150);
            listViewAccepted.Columns.Add("Additional Notes", 200);

            LoadAcceptedAppointments();
        }

        private void listViewAccepted_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAccepted.SelectedItems.Count > 0)
            {
                if (int.TryParse(listViewAccepted.SelectedItems[0].SubItems[0].Text, out int apptId))
                {
                    selectedAppointmentId = apptId;
                }
            }
            else
            {
                selectedAppointmentId = -1;
            }
        }

        private void LoadAcceptedAppointments()
        {
            listViewAccepted.Items.Clear();

            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT appointment_number, patient_name, appointment_datetime, status, gender, age, date_of_birth, phone_number, email, current_medication, additional_notes " +
                                   "FROM booking WHERE status = 'Accepted' ORDER BY appointment_datetime DESC";

                    using (var cmd = new MySqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["appointment_number"].ToString());
                            item.SubItems.Add(reader["patient_name"].ToString());
                            item.SubItems.Add(Convert.ToDateTime(reader["appointment_datetime"]).ToString("yyyy-MM-dd hh:mm tt"));
                            item.SubItems.Add(reader["status"].ToString());
                            item.SubItems.Add(reader["gender"].ToString());
                            item.SubItems.Add(reader["age"].ToString());
                            item.SubItems.Add(Convert.ToDateTime(reader["date_of_birth"]).ToString("yyyy-MM-dd"));
                            item.SubItems.Add(reader["phone_number"].ToString());
                            item.SubItems.Add(reader["email"].ToString());
                            item.SubItems.Add(reader["current_medication"].ToString());
                            item.SubItems.Add(reader["additional_notes"].ToString());

                            listViewAccepted.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading accepted appointments: " + ex.Message);
            }
        }

        private void btnCompleteBook_Click(object sender, EventArgs e)
        {
            if (selectedAppointmentId == -1)
            {
                MessageBox.Show("Please select an appointment first.");
                return;
            }

            var confirmResult = MessageBox.Show(
                $"Are you sure you want to mark appointment No. {selectedAppointmentId} as COMPLETED?",
                "Confirm Completion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                UpdateBookingStatus(selectedAppointmentId, "Completed");
            }
        }

        private void btnCancelBook_Click(object sender, EventArgs e)
        {
            if (selectedAppointmentId == -1)
            {
                MessageBox.Show("Please select an appointment first.");
                return;
            }

            var confirmResult = MessageBox.Show(
                $"Are you sure you want to CANCEL appointment No. {selectedAppointmentId}?",
                "Confirm Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmResult == DialogResult.Yes)
            {
                UpdateBookingStatus(selectedAppointmentId, "Cancelled");
            }
        }

        private void UpdateBookingStatus(int appointmentNumber, string newStatus)
        {
            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE booking SET status = @status WHERE appointment_number = @apptNum";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", newStatus);
                        cmd.Parameters.AddWithValue("@apptNum", appointmentNumber);
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show($"Appointment status changed to '{newStatus}' successfully.");
                            LoadAcceptedAppointments(); // refresh the list
                        }
                        else
                        {
                            MessageBox.Show("Failed to update appointment.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }
    }
}