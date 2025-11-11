using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace admindash.Dashboard
{
    public partial class MainDashboard : Form
    {
        public string connectionString = "Server=oop-prms-iqperia06-3946oop.e.aivencloud.com;" +
                                         "Port=19631;" +
                                         "Database=oop_project;" +
                                         "User ID=avnadmin;" +
                                         "Password=AVNS_DC-Fjd1udeFkVwK429X;" +
                                         "SslMode=Required;";

        private int selectedAppointmentId = -1;

        public MainDashboard()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;

            this.Load += MainDashboard_Load;
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
            listViewAppointments.Columns.Add("Patient Name", 180);
            listViewAppointments.Columns.Add("Appointment Date & Time", 200);
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

                    string query = @"
                        SELECT appointment_number, patient_name, appointment_datetime
                        FROM booking 
                        WHERE status = 'Pending'
                        ORDER BY appointment_datetime ASC";

                    using (var cmd = new MySqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string apptNo = reader["appointment_number"].ToString();
                            string name = reader["patient_name"].ToString();

                            DateTime apptDate = Convert.ToDateTime(reader["appointment_datetime"]);
                            string formattedDate = apptDate.ToString("yyyy-MM-dd hh:mm tt");

                            ListViewItem item = new ListViewItem(apptNo);
                            item.SubItems.Add(name);
                            item.SubItems.Add(formattedDate);

                            listViewAppointments.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointments: " + ex.Message);
            }
        }

        // ===============================
        //  SELECTING AN APPOINTMENT
        // ===============================
        private void listViewAppointments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAppointments.SelectedItems.Count == 0)
            {
                selectedAppointmentId = -1;
                return;
            }

            ListViewItem selectedItem = listViewAppointments.SelectedItems[0];
            selectedAppointmentId = int.Parse(selectedItem.Text); // Appointment No. is the first column
        }

        // ===============================
        //  ACCEPT / DECLINE STATUS UPDATE
        // ===============================
        private void btnAcceptAppointment_Click(object sender, EventArgs e)
        {
            if (selectedAppointmentId == -1)
            {
                MessageBox.Show("Please select an appointment first.");
                return;
            }

            UpdateBookingStatus(selectedAppointmentId, "Accepted");
        }

        private void btnDeclineAppointment_Click(object sender, EventArgs e)
        {
            if (selectedAppointmentId == -1)
            {
                MessageBox.Show("Please select an appointment first.");
                return;
            }

            UpdateBookingStatus(selectedAppointmentId, "Declined");
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
                            MessageBox.Show($"Appointment {status.ToLower()} successfully.");
                            LoadAppointments(); // refresh list
                            selectedAppointmentId = -1;
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
