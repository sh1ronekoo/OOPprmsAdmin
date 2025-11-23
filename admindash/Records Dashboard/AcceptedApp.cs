using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace admindash.Records_Dashboard
{
    public partial class AcceptedApp : Form
    {
        private string connectionString = "Server=oop-prms-iqperia06-3946oop.e.aivencloud.com;Port=19631;Database=oop_project;User ID=avnadmin;Password=AVNS_DC-Fjd1udeFkVwK429X;SslMode=Required;";
        private int selectedAppointmentId = -1; // store the currently selected appointment number

        public AcceptedApp()
        {
            InitializeComponent();
            this.Load += AcceptedApp_Load;

            // Wire up SelectedIndexChanged for ListView
            listViewAccepted.SelectedIndexChanged += listViewAccepted_SelectedIndexChanged;
        }

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
            // Existing patient columns
            listViewAccepted.Columns.Add("Gender", 80);
            listViewAccepted.Columns.Add("Age", 50);
            listViewAccepted.Columns.Add("DOB", 100);
            listViewAccepted.Columns.Add("Phone No.", 120);
            // Newly added columns
            listViewAccepted.Columns.Add("Email", 120);
            listViewAccepted.Columns.Add("Medication", 150);
            listViewAccepted.Columns.Add("Additional Notes", 200);

            LoadAcceptedAppointments();
        }

        private void LoadAcceptedAppointments()
        {
            listViewAccepted.Items.Clear();

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    // UPDATED: Added email, current_medication, and additional_notes to the SELECT query
                    string query = "SELECT appointment_number, patient_name, appointment_datetime, status, gender, age, date_of_birth, phone_number, email, current_medication, additional_notes " +
                                   "FROM booking WHERE status = 'Accepted' ORDER BY appointment_datetime DESC";

                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string apptNo = reader["appointment_number"].ToString();
                            string name = reader["patient_name"].ToString();
                            DateTime apptDate = Convert.ToDateTime(reader["appointment_datetime"]);
                            string apptFormatted = apptDate.ToString("yyyy-MM-dd hh:mm tt");
                            string status = reader["status"].ToString();

                            // Patient Info (Existing)
                            string gender = reader["gender"].ToString();
                            string age = reader["age"].ToString();
                            string dob = Convert.ToDateTime(reader["date_of_birth"]).ToString("yyyy-MM-dd");
                            string phone = reader["phone_number"].ToString();

                            // Patient Info (New)
                            string email = reader["email"].ToString();
                            string medication = reader["current_medication"].ToString();
                            string notes = reader["additional_notes"].ToString();

                            ListViewItem item = new ListViewItem(apptNo);
                            item.SubItems.Add(name);
                            item.SubItems.Add(apptFormatted);
                            item.SubItems.Add(status);

                            // Add existing patient subitems
                            item.SubItems.Add(gender);
                            item.SubItems.Add(age);
                            item.SubItems.Add(dob);
                            item.SubItems.Add(phone);

                            // Add new patient subitems
                            item.SubItems.Add(email);
                            item.SubItems.Add(medication);
                            item.SubItems.Add(notes);

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

        private void btnCompleteBook_Click(object sender, EventArgs e)
        {
            if (selectedAppointmentId == -1)
            {
                MessageBox.Show("Please select an appointment first.");
                return;
            }

            // Confirmation Prompt
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

        // Assuming a button named 'btnCancel' exists to cancel an accepted appointment
        private void btnCancelBook_Click(object sender, EventArgs e)
        {
            if (selectedAppointmentId == -1)
            {
                MessageBox.Show("Please select an appointment first.");
                return;
            }

            // Confirmation Prompt
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
                using (var conn = new MySqlConnection(connectionString))
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