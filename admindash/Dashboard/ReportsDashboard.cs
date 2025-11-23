using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO; // Added for file export operations
using System.Text;

namespace admindash.Dashboard
{
    public partial class ReportsDashboard : Form
    {
        private string connectionString = "Server=oop-prms-iqperia06-3946oop.e.aivencloud.com;" +
                                          "Port=19631;" +
                                          "Database=oop_project;" +
                                          "User ID=avnadmin;" +
                                          "Password=AVNS_DC-Fjd1udeFkVwK429X;" +
                                          "SslMode=Required;";

        public ReportsDashboard()
        {
            InitializeComponent();
            LoadReportData();
        }

        private void LoadReportData()
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // TOTAL BOOKINGS
                    lblTotalBookings.Text = GetCount(conn, "SELECT COUNT(*) FROM booking").ToString();

                    // COMPLETED BOOKINGS
                    lblCompleted.Text = GetCount(conn, "SELECT COUNT(*) FROM booking WHERE status='Completed'").ToString();

                    // PENDING BOOKINGS
                    lblPending.Text = GetCount(conn, "SELECT COUNT(*) FROM booking WHERE status='Pending'").ToString();

                    // ACCEPTED BOOKINGS
                    lblAccepted.Text = GetCount(conn, "SELECT COUNT(*) FROM booking WHERE status='Accepted'").ToString();

                    // DECLINED BOOKINGS
                    lblDeclined.Text = GetCount(conn, "SELECT COUNT(*) FROM booking WHERE status='Declined'").ToString();

                    // CANCELLED BOOKINGS
                    lblCancelled.Text = GetCount(conn, "SELECT COUNT(*) FROM booking WHERE status='Cancelled'").ToString();

                    // DAILY BOOKINGS
                    lblDaily.Text = GetCount(conn, "SELECT COUNT(*) FROM booking WHERE DATE(appointment_datetime)=CURDATE()").ToString();

                    // WEEKLY BOOKINGS
                    lblWeekly.Text = GetCount(conn, "SELECT COUNT(*) FROM booking WHERE YEARWEEK(appointment_datetime)=YEARWEEK(CURDATE())").ToString();

                    // MONTHLY BOOKINGS
                    lblMonthly.Text = GetCount(conn, "SELECT COUNT(*) FROM booking WHERE MONTH(appointment_datetime)=MONTH(CURDATE()) AND YEAR(appointment_datetime)=YEAR(CURDATE())").ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report data: " + ex.Message);
            }
        }

        private int GetCount(MySqlConnection conn, string query)
        {
            using (var cmd = new MySqlCommand(query, conn))
            {
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        // Method restored as requested
        private void btnExportPdf_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV File (*.csv)|*.csv|All files (*.*)|*.*";
                sfd.Title = "Export Detailed Booking Records to CSV";
                sfd.FileName = $"Detailed_Booking_Report_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // 1. Fetch all data from the booking table using the specified columns
                        DataTable dt = new DataTable();
                        string dataQuery = "SELECT appointment_number, appointment_datetime, submission_datetime, patient_name, " +
                                           "gender, age, date_of_birth, phone_number, email, address, " +
                                           "current_medication, additional_notes, status " +
                                           "FROM booking ORDER BY appointment_datetime DESC";

                        using (var conn = new MySqlConnection(connectionString))
                        {
                            conn.Open();
                            using (var cmd = new MySqlCommand(dataQuery, conn))
                            {
                                using (var adapter = new MySqlDataAdapter(cmd))
                                {
                                    adapter.Fill(dt);
                                }
                            }
                        }

                        // 2. Build the CSV content
                        var sb = new StringBuilder();

                        // Add Header Row dynamically
                        // The column names will be the field names from the database: appointment_number, patient_name, etc.
                        string[] columnNames = dt.Columns.Cast<DataColumn>().Select(column => column.ColumnName).ToArray();
                        sb.AppendLine(string.Join(",", columnNames));

                        // Add Data Rows
                        foreach (DataRow row in dt.Rows)
                        {
                            string[] fields = row.ItemArray.Select(field =>
                                // CSV field cleaning: escape quotes and surround field with quotes if it contains commas, newlines, or tabs.
                                $"\"{field.ToString().Replace("\"", "\"\"").Replace("\r", " ").Replace("\n", " ").Trim()}\""
                            ).ToArray();
                            sb.AppendLine(string.Join(",", fields));
                        }

                        // 3. Write the CSV content to the file
                        File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);

                        MessageBox.Show($"Detailed booking records successfully exported to:\n{sfd.FileName}",
                                        "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred during export: " + ex.Message,
                                        "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}