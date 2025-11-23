using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace admindash.Core
{
    // ABSTRACTION: This class handles ALL database interaction. 
    // The UI forms don't need to know about "SELECT" or "UPDATE" queries.
    public class AppointmentService
    {
        // Polymorphism/Overloading: Fetch all or fetch by status
        public List<Appointment> GetAppointments(string statusFilter = null)
        {
            List<Appointment> list = new List<Appointment>();

            using (var conn = DatabaseConfig.GetConnection())
            {
                conn.Open();
                string query = "SELECT appointment_number, patient_name, appointment_datetime, status FROM booking";

                if (!string.IsNullOrEmpty(statusFilter))
                {
                    query += " WHERE status = @status";
                }

                query += " ORDER BY appointment_datetime DESC"; // Default ordering

                using (var cmd = new MySqlCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(statusFilter))
                    {
                        cmd.Parameters.AddWithValue("@status", statusFilter);
                    }

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Appointment
                            {
                                AppointmentNumber = Convert.ToInt32(reader["appointment_number"]),
                                PatientName = reader["patient_name"].ToString(),
                                AppointmentDate = Convert.ToDateTime(reader["appointment_datetime"]),
                                Status = reader["status"].ToString()
                            });
                        }
                    }
                }
            }
            return list;
        }

        public bool UpdateStatus(int id, string newStatus)
        {
            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE booking SET status = @status WHERE appointment_number = @id";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", newStatus);
                        cmd.Parameters.AddWithValue("@id", id);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public int GetCount(string status = null)
        {
            using (var conn = DatabaseConfig.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM booking";
                if (status != null) query += " WHERE status = @status";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    if (status != null) cmd.Parameters.AddWithValue("@status", status);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        // Specific queries for reports
        public int GetDailyCount() => GetDateCount("DATE(appointment_datetime)=CURDATE()");
        public int GetWeeklyCount() => GetDateCount("YEARWEEK(appointment_datetime)=YEARWEEK(CURDATE())");
        public int GetMonthlyCount() => GetDateCount("MONTH(appointment_datetime)=MONTH(CURDATE()) AND YEAR(appointment_datetime)=YEAR(CURDATE())");

        private int GetDateCount(string dateCondition)
        {
            using (var conn = DatabaseConfig.GetConnection())
            {
                conn.Open();
                string query = $"SELECT COUNT(*) FROM booking WHERE {dateCondition}";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
    }
}