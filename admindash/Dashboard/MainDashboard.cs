using MySql.Data.MySqlClient;

namespace admindash.Dashboard
{
    public partial class MainDashboard : Form
    {
        // Now using the centralized connection string from DatabaseHelper
        public string connectionString = DatabaseHelper.connectionString;

        private int selectedAppointmentId = -1;

        public MainDashboard()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

            this.Load += MainDashboard_Load;

            // Wire up SelectedIndexChanged for ListView
            listViewAppointments.SelectedIndexChanged += listViewAppointments_SelectedIndexChanged;
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            SetupListView();
            LoadAppointments();
        }

        // ===============================
        //  SETUP LISTVIEW COLUMNS
        // ===============================
        private void SetupListView()
        {
            listViewAppointments.View = View.Details;
            listViewAppointments.FullRowSelect = true;
            listViewAppointments.GridLines = true;

            listViewAppointments.Columns.Clear();
            listViewAppointments.Columns.Add("Appointment No.", 120);
            listViewAppointments.Columns.Add("Patient Name", 150);
            listViewAppointments.Columns.Add("Appointment Date & Time", 200);
            listViewAppointments.Columns.Add("Status", 120);
            // Existing patient columns
            listViewAppointments.Columns.Add("Gender", 80);
            listViewAppointments.Columns.Add("Age", 50);
            listViewAppointments.Columns.Add("DOB", 100);
            listViewAppointments.Columns.Add("Phone No.", 120);
            // Newly added columns
            listViewAppointments.Columns.Add("Email", 120);
            listViewAppointments.Columns.Add("Medication", 150);
            listViewAppointments.Columns.Add("Additional Notes", 200);
        }

        // ===============================
        //  HANDLE SELECTION
        // ===============================
        private void listViewAppointments_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear previous selection
            selectedAppointmentId = -1;

            if (listViewAppointments.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewAppointments.SelectedItems[0];
                // The first sub-item is the Appointment No.
                if (int.TryParse(selectedItem.SubItems[0].Text, out int apptId))
                {
                    selectedAppointmentId = apptId;
                }
                else
                {
                    Logger.Warn($"Failed to parse appointment ID from list view: {selectedItem.SubItems[0].Text}");
                }
            }
        }

        // ===============================
        //  LOAD PENDING APPOINTMENTS
        // ===============================
        public void LoadAppointments()
        {
            listViewAppointments.Items.Clear();

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    // UPDATED: Added email, current_medication, and additional_notes to the SELECT query
                    string query = "SELECT appointment_number, patient_name, appointment_datetime, status, gender, age, date_of_birth, phone_number, email, current_medication, additional_notes " +
                                   "FROM booking WHERE status = 'Pending' ORDER BY appointment_datetime DESC";

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


                            listViewAppointments.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading pending appointments: " + ex.Message);
            }
        }

        // ===============================
        //  BUTTON CLICKS
        // ===============================
        private void btnAcceptAppointment_Click(object sender, EventArgs e)
        {
            if (selectedAppointmentId == -1)
            {
                MessageBox.Show("Please select an appointment first.");
                return;
            }

            // Confirmation Prompt
            var confirmResult = MessageBox.Show(
                $"Are you sure you want to ACCEPT appointment No. {selectedAppointmentId}?",
                "Confirm Acceptance",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                UpdateBookingStatus(selectedAppointmentId, "Accepted");
            }
        }

        private void btnDeclineAppointment_Click(object sender, EventArgs e)
        {
            if (selectedAppointmentId == -1)
            {
                MessageBox.Show("Please select an appointment first.");
                return;
            }

            // Confirmation Prompt
            var confirmResult = MessageBox.Show(
                $"Are you sure you want to DECLINE appointment No. {selectedAppointmentId}?",
                "Confirm Decline",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmResult == DialogResult.Yes)
            {
                UpdateBookingStatus(selectedAppointmentId, "Declined");
            }
        }

        private void UpdateBookingStatus(int appointmentNumber, string status)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "UPDATE booking SET status = @status WHERE appointment_number = @apptNum";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@apptNum", appointmentNumber);
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            Logger.Info($"Appointment {appointmentNumber} status updated to {status}.");
                            MessageBox.Show($"Appointment {status.ToLower()} successfully.");
                            LoadAppointments(); // refresh list
                            selectedAppointmentId = -1;
                        }
                        else
                        {
                            Logger.Warn($"Failed to update appointment {appointmentNumber} status to {status}. No rows affected.");
                            MessageBox.Show("Failed to update appointment.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"Database error updating appointment {appointmentNumber} status: {ex.Message}");
                MessageBox.Show("Database error: " + ex.Message);
            }
        }
    }
}