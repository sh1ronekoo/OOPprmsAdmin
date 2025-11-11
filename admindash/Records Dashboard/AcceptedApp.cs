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

            LoadAcceptedAppointments();
        }

        private void LoadAcceptedAppointments()
        {
            listViewAccepted.Items.Clear();
            selectedAppointmentId = -1; // reset selection

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT appointment_number, patient_name, appointment_datetime, status FROM booking WHERE status = 'Accepted' ORDER BY appointment_datetime DESC";

                    using (var cmd = new MySqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string apptNo = reader["appointment_number"].ToString();
                            string name = reader["patient_name"].ToString();
                            DateTime apptDate = Convert.ToDateTime(reader["appointment_datetime"]);
                            string apptFormatted = apptDate.ToString("yyyy-MM-dd hh:mm tt");
                            string status = reader["status"].ToString();

                            ListViewItem item = new ListViewItem(apptNo);
                            item.SubItems.Add(name);
                            item.SubItems.Add(apptFormatted);
                            item.SubItems.Add(status);

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

        // Track selection
        private void listViewAccepted_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAccepted.SelectedItems.Count > 0)
            {
                selectedAppointmentId = Convert.ToInt32(listViewAccepted.SelectedItems[0].SubItems[0].Text);
            }
            else
            {
                selectedAppointmentId = -1;
            }
        }

        private void btnCancelBook_Click(object sender, EventArgs e)
        {
            if (selectedAppointmentId == -1)
            {
                MessageBox.Show("Please select an appointment first.");
                return;
            }
            UpdateBookingStatus(selectedAppointmentId, "Cancelled");
        }

        private void btnCompleteBook_Click(object sender, EventArgs e)
        {
            if (selectedAppointmentId == -1)
            {
                MessageBox.Show("Please select an appointment first.");
                return;
            }
            UpdateBookingStatus(selectedAppointmentId, "Completed");
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
                            MessageBox.Show($"Appointment {newStatus.ToLower()} successfully.");
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
