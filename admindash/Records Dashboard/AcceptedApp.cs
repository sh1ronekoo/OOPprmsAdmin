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
                    string query = "SELECT appointment_number, patient_name, appointment_datetime, gender, age, date_of_birth, phone_number, email, current_medication, additional_notes " +
                                   "FROM booking WHERE status = 'Accepted' ORDER BY appointment_datetime DESC";

                    using (var cmd = new MySqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["appointment_number"].ToString());
                            item.SubItems.Add(reader["patient_name"].ToString());
                            item.SubItems.Add(Convert.ToDateTime(reader["appointment_datetime"]).ToString("yyyy-MM-dd hh:mm tt"));
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

            using (var form = new CompleteAppointmentForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    UpdateCompletedAppointment(
                        selectedAppointmentId,
                        form.Diagnosis,
                        form.Findings,
                        form.Prescription
                    );
                }
            }
        }


        private void btnCancelBook_Click(object sender, EventArgs e)
        {
            if (selectedAppointmentId == -1)
            {
                MessageBox.Show("Please select an appointment first.");
                return;
            }

            using (var form = new CancelAppointmentForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    UpdateCancelledAppointment(
                        selectedAppointmentId,
                        form.CancellationReason
                    );
                }
            }
        }

        private void UpdateCompletedAppointment(
            int appointmentNumber,
            string diagnosis,
            string findings,
            string prescription)
        {
            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                        string query = @"UPDATE booking 
                                SET status = 'Completed',
                                diagnosis = @diagnosis,
                                findings = @findings,
                                prescription = @prescription
                                WHERE appointment_number = @apptNum";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@diagnosis", diagnosis);
                        cmd.Parameters.AddWithValue("@findings", findings);
                        cmd.Parameters.AddWithValue("@prescription", prescription);
                        cmd.Parameters.AddWithValue("@apptNum", appointmentNumber);

                    cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Appointment marked as COMPLETED.");
                LoadAcceptedAppointments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void UpdateCancelledAppointment(
            int appointmentNumber,
            string reason)
        {
            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                        string query = @"UPDATE booking
                        SET status = 'Cancelled',
                        cancellation_reason = @reason
                        WHERE appointment_number = @apptNum";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@reason", reason);
                        cmd.Parameters.AddWithValue("@apptNum", appointmentNumber);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Appointment cancelled successfully.");
                LoadAcceptedAppointments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        public void Search(string keyword)
        {
        }

    }
}