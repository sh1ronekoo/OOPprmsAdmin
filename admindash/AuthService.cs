using System;
using MySql.Data.MySqlClient;

namespace admindash.Core
{
    // ABSTRACTION: Handles all User Account Database interactions
    public class AuthService
    {
        public bool ValidateLogin(string username, string password)
        {
            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM login WHERE users = @username AND pass = @password";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public bool UserExists(string username)
        {
            using (var conn = DatabaseConfig.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM login WHERE users = @user";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        public bool CreateUser(string username, string password)
        {
            try
            {
                using (var conn = DatabaseConfig.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO login (users, pass) VALUES (@user, @pass)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", username);
                        cmd.Parameters.AddWithValue("@pass", password);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database error: " + ex.Message);
            }
        }
    }
}