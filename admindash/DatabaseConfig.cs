using System;
using MySql.Data.MySqlClient;

namespace admindash.Core
{
    // ENCAPSULATION: We hide the connection string details here.
    // Other classes don't need to know the password or server, they just ask for a connection.
    public static class DatabaseConfig
    {
        private static readonly string _connectionString =
            "Server=oop-prms-iqperia06-3946oop.e.aivencloud.com;" +
            "Port=19631;" +
            "Database=oop_project;" +
            "User ID=avnadmin;" +
            "Password=AVNS_DC-Fjd1udeFkVwK429X;" +
            "SslMode=Required;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(_connectionString);
        }
    }
}