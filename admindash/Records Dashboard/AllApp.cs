using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Add MySql import
using admindash.Core;

namespace admindash.Records_Dashboard
{
    public partial class AllApp : Form
    {
        public AllApp()
        {
            InitializeComponent();
            this.Load += AllApp_Load;
        }

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
            // Existing patient columns
            listViewAll.Columns.Add("Gender", 80);
            listViewAll.Columns.Add("Age", 50);
            listViewAll.Columns.Add("DOB", 100);
            listViewAll.Columns.Add("Phone No.", 120);
            // Newly added columns
            listViewAll.Columns.Add("Email", 120);
            listViewAll.Columns.Add("Medication", 150);
            listViewAll.Columns.Add("Additional Notes", 200);

            LoadAllAppointments();
        }

        private void LoadAllAppointments()
        {
            listViewAll.Items.Clear();

            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    // UPDATED: Added email, current_medication, and additional_notes to the SELECT query
                    string query = "SELECT appointment_number, patient_name, appointment_datetime, status, gender, age, date_of_birth, phone_number, email, current_medication, additional_notes " +
                                   "FROM booking ORDER BY appointment_datetime DESC";

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

                            listViewAll.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading all appointments: " + ex.Message);
            }
        }
    }
}