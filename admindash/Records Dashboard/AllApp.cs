using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admindash.Records_Dashboard
{
    public partial class AllApp : Form
    {
        private string connectionString = "Server=oop-prms-iqperia06-3946oop.e.aivencloud.com;" +
                                          "Port=19631;" +
                                          "Database=oop_project;" +
                                          "User ID=avnadmin;" +
                                          "Password=AVNS_DC-Fjd1udeFkVwK429X;" +
                                          "SslMode=Required;";

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

            LoadAcceptedAppointments();
        }

        private void LoadAcceptedAppointments()
        {
            listViewAll.Items.Clear();

            try
            {
                using (var conn = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT appointment_number, patient_name, appointment_datetime, status FROM booking ORDER BY appointment_datetime DESC";

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

                            ListViewItem item = new ListViewItem(apptNo);
                            item.SubItems.Add(name);
                            item.SubItems.Add(apptFormatted);
                            item.SubItems.Add(status);

                            listViewAll.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading accepted appointments: " + ex.Message);
            }
        }
    }

}
