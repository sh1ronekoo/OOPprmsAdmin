using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using admindash.Core;

namespace admindash.Records_Dashboard
{
    public partial class DeclinedApp : Form, IRecordView
    {
        private int _selectedId = -1;

        public DeclinedApp()
        {
            InitializeComponent();
            this.Load += DeclinedApp_Load;
            listViewDeclined.SelectedIndexChanged += listViewDeclined_SelectedIndexChanged;
        }

        // Interface Implementation
        public int GetSelectedAppointmentId() => _selectedId;
        public void RefreshData() => LoadDeclinedAppointments();

        private void DeclinedApp_Load(object sender, EventArgs e)
        {
            listViewDeclined.View = View.Details;
            listViewDeclined.FullRowSelect = true;
            listViewDeclined.GridLines = true;

            listViewDeclined.Columns.Clear();
            listViewDeclined.Columns.Add("Appointment No.", 120);
            listViewDeclined.Columns.Add("Patient Name", 150);
            listViewDeclined.Columns.Add("Appointment Date & Time", 200);
            listViewDeclined.Columns.Add("Gender", 80);
            listViewDeclined.Columns.Add("Age", 50);
            listViewDeclined.Columns.Add("DOB", 100);
            listViewDeclined.Columns.Add("Phone No.", 120);
            listViewDeclined.Columns.Add("Email", 120);
            listViewDeclined.Columns.Add("Medication", 150);
            listViewDeclined.Columns.Add("Additional Notes", 200);

            LoadDeclinedAppointments();
        }

        private void listViewDeclined_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDeclined.SelectedItems.Count > 0)
            {
                if (int.TryParse(listViewDeclined.SelectedItems[0].SubItems[0].Text, out int id))
                {
                    _selectedId = id;
                }
            }
            else
            {
                _selectedId = -1;
            }
        }

        private void LoadDeclinedAppointments()
        {
            listViewDeclined.Items.Clear();

            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT appointment_number, patient_name, appointment_datetime, gender, age, date_of_birth, phone_number, email, current_medication, additional_notes " +
                                   "FROM booking WHERE status = 'Declined' ORDER BY appointment_datetime DESC";

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

                            listViewDeclined.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading declined appointments: " + ex.Message);
            }
        }

        public void Search(string keyword)
        {
        }
    }
}