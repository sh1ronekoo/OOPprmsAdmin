using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace admindash
{
    public partial class Login : Form
    {
        // Now using the centralized connection string from DatabaseHelper
        string connectionString = DatabaseHelper.connectionString;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both username and password.",
                    "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM login WHERE users = @username AND pass = @password";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            Logger.Info($"User {username} logged in successfully.");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            Logger.Warn($"Failed login attempt for user: {username}");
                            MessageBox.Show("Invalid username or password.",
                                "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error($"Database error during login for {username}: {ex.Message}");
                MessageBox.Show("Error connecting to database:\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabelCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open create account form
            CreateAccount create = new CreateAccount();

            // Show as dialog so Program.cs knows how to continue
            var result = create.ShowDialog();

            if (result == DialogResult.OK)
            {
                // After account creation, auto-fill username if you want
                // txtUsername.Text = create.CreatedUsername;

                MessageBox.Show("Account created! Please log in.");
            }
            // Ensure the form is disposed of
            create.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}