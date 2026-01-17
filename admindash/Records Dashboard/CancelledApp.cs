using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using admindash.Core;

namespace admindash.Records_Dashboard
{
    public partial class CancelledApp : Form, IRecordView
    {
        private int _selectedId = -1;

        public CancelledApp()
        {
            InitializeComponent();
            this.Load += CancelledApp_Load;
            listViewCancelled.SelectedIndexChanged += listViewCancelled_SelectedIndexChanged;
        }

        // Interface Implementation
        public int GetSelectedAppointmentId() => _selectedId;
        public void RefreshData() => LoadCancelledAppointments();

        private void CancelledApp_Load(object sender, EventArgs e)
        {
            listViewCancelled.View = View.Details;
            listViewCancelled.FullRowSelect = true;
            listViewCancelled.GridLines = true;

            listViewCancelled.Columns.Clear();
            listViewCancelled.Columns.Add("Appointment No.", 120);
            listViewCancelled.Columns.Add("Patient Name", 150);
            listViewCancelled.Columns.Add("Appointment Date & Time", 200);
            listViewCancelled.Columns.Add("Cancellation Reason", 300);

            LoadCancelledAppointments();
        }

        private void listViewCancelled_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCancelled.SelectedItems.Count > 0)
            {
                if (int.TryParse(listViewCancelled.SelectedItems[0].SubItems[0].Text, out int id))
                {
                    _selectedId = id;
                }
            }
            else
            {
                _selectedId = -1;
            }
        }

        private void LoadCancelledAppointments()
        {
            listViewCancelled.Items.Clear();

            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT appointment_number, patient_name, appointment_datetime, cancellation_reason " +
                                   "FROM booking WHERE status = 'Cancelled' ORDER BY appointment_datetime DESC";

                    using (var cmd = new MySqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["appointment_number"].ToString());
                            item.SubItems.Add(reader["patient_name"].ToString());
                            item.SubItems.Add(Convert.ToDateTime(reader["appointment_datetime"]).ToString("yyyy-MM-dd hh:mm tt"));
                            item.SubItems.Add(reader["cancellation_reason"].ToString());

                            listViewCancelled.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cancelled appointments: " + ex.Message);
            }
        }
        public void Search(string keyword)
        {
        }
    }
}