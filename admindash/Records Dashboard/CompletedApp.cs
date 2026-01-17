using admindash.Core;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace admindash.Records_Dashboard
{
    public partial class CompletedApp : Form, IRecordView
    {
        private int _selectedId = -1;

        public CompletedApp()
        {
            InitializeComponent();
            this.Load += CompletedApp_Load;
            listViewCompleted.SelectedIndexChanged += listViewCompleted_SelectedIndexChanged;
        }

        // Interface Implementation
        public int GetSelectedAppointmentId() => _selectedId;
        public void RefreshData() => LoadCompletedAppointments();

        private void CompletedApp_Load(object sender, EventArgs e)
        {
            listViewCompleted.View = View.Details;
            listViewCompleted.FullRowSelect = true;
            listViewCompleted.GridLines = true;

            listViewCompleted.Columns.Clear();
            listViewCompleted.Columns.Add("Appointment No.", 120);
            listViewCompleted.Columns.Add("Patient Name", 150);
            listViewCompleted.Columns.Add("Appointment Date & Time", 200);
            listViewCompleted.Columns.Add("Diagnosis", 120);
            listViewCompleted.Columns.Add("Findings", 150);
            listViewCompleted.Columns.Add("Prescription", 150);

            LoadCompletedAppointments();
        }

        private void listViewCompleted_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCompleted.SelectedItems.Count > 0)
            {
                if (int.TryParse(listViewCompleted.SelectedItems[0].SubItems[0].Text, out int id))
                {
                    _selectedId = id;
                }
            }
            else
            {
                _selectedId = -1;
            }
        }

        private void LoadCompletedAppointments()
        {
            listViewCompleted.Items.Clear();

            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT appointment_number, patient_name, appointment_datetime, diagnosis, findings, prescription " +
                                   "FROM booking WHERE status = 'Completed' ORDER BY appointment_datetime DESC";

                    using (var cmd = new MySqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["appointment_number"].ToString());
                            item.SubItems.Add(reader["patient_name"].ToString());
                            item.SubItems.Add(Convert.ToDateTime(reader["appointment_datetime"]).ToString("yyyy-MM-dd hh:mm tt"));
                            item.SubItems.Add(reader["diagnosis"].ToString());
                            item.SubItems.Add(reader["findings"].ToString());
                            item.SubItems.Add(reader["prescription"].ToString());

                            listViewCompleted.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading completed appointments: " + ex.Message);
            }
        }
        public void Search(string keyword)
        {
        }
    }
}