using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
    }
}
