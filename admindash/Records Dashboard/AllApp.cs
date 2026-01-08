using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using admindash.Core;

namespace admindash.Records_Dashboard
{
    public partial class AllApp : Form, IRecordView
    {
        private int _selectedId = -1;

        public AllApp()
        {
            InitializeComponent();
            this.Load += AllApp_Load;
            // IMPORTANT: Wire up event manually to ensure it triggers
            listViewAll.SelectedIndexChanged += listViewAll_SelectedIndexChanged;
        }

        // Interface Implementation
        public int GetSelectedAppointmentId() => _selectedId;
        public void RefreshData() => LoadAllAppointments();

        private void AllApp_Load(object sender, EventArgs e)
        {
            listViewAll.View = View.Details;
            listViewAll.FullRowSelect = true;
            listViewAll.GridLines = true;

            listViewAll.Columns.Clear();
            listViewAll.Columns.Add("Appointment No.", 120);
            listViewAll.Columns.Add("Patient Name", 150);
            listViewAll.Columns.Add("Appointment Date & Time", 200);
            listViewAll.Columns.Add("Status", 120);
            listViewAll.Columns.Add("Gender", 80);
            listViewAll.Columns.Add("Age", 50);
            listViewAll.Columns.Add("DOB", 100);
            listViewAll.Columns.Add("Phone No.", 120);
            listViewAll.Columns.Add("Email", 120);
            listViewAll.Columns.Add("Medication", 150);
            listViewAll.Columns.Add("Additional Notes", 200);

            LoadAllAppointments();
        }

        private void listViewAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAll.SelectedItems.Count > 0)
            {
                if (int.TryParse(listViewAll.SelectedItems[0].SubItems[0].Text, out int id))
                {
                    _selectedId = id;
                }
            }
            else
            {
                _selectedId = -1;
            }
        }

        private void LoadAllAppointments(string keyword = "")
        {
            listViewAll.Items.Clear();

            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();

                    string query =
                        "SELECT appointment_number, patient_name, appointment_datetime, status, gender, age, date_of_birth, phone_number, email, current_medication, additional_notes " +
                        "FROM booking " +
                        "WHERE (@keyword = '' OR " +
                        "appointment_number LIKE @kw OR " +
                        "patient_name LIKE @kw OR " +
                        "phone_number LIKE @kw OR " +
                        "email LIKE @kw OR " +
                        "status LIKE @kw) " +
                        "ORDER BY appointment_datetime DESC";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@keyword", keyword);
                        cmd.Parameters.AddWithValue("@kw", $"%{keyword}%");

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

                                listViewAll.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointments: " + ex.Message);
            }
        }

        public void Search(string keyword)
        {
            LoadAllAppointments(keyword);
        }

    }
}