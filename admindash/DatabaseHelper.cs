using MySql.Data.MySqlClient;
using System;

namespace admindash
{
    public static class DatabaseHelper
    {
        public static string connectionString = "Server=oop-prms-iqperia06-3946oop.e.aivencloud.com;" +
                                                 "Port=19631;" +
                                                 "Database=oop_project;" +
                                                 "User ID=avnadmin;" +
                                                 "Password=AVNS_DC-Fjd1udeFkVwK429X;" +
                                                 "SslMode=Required;";

        public static bool HasAnyAccount()
        {
            bool exists = false;

            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM login"; // your table name
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        exists = count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log database error
                Logger.Error($"Database check for existing accounts failed: {ex.Message}");
                exists = false;
            }

            return exists;
        }
    }
}