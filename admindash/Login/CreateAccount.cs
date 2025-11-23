using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace admindash
{
    public partial class CreateAccount : Form
    {
        // Now using the centralized connection string from DatabaseHelper
        string connectionString = DatabaseHelper.connectionString;

        public CreateAccount()
        {
            InitializeComponent();
        }


        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string username = txtCreateUsername.Text.Trim();
            string password = txtCreatePassword.Text.Trim();
            string confirm = txtCreateConfirmPassword.Text.Trim();

            // ◀ Validation
            if (username == "" || password == "" || confirm == "")
            {
                MessageBox.Show("Please fill out all fields.",
                    "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // ◀ Check for duplicate username
                    string checkQuery = "SELECT COUNT(*) FROM login WHERE users = @user";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@user", username);
                        int exists = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (exists > 0)
                        {
                            MessageBox.Show("That username already exists.",
                                "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // ◀ Insert new account
                    string insertQuery = "INSERT INTO login (users, pass) VALUES (@user, @pass)";
                    using (MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@user", username);
                        insertCmd.Parameters.AddWithValue("@pass", password); // plaintext for now
                        insertCmd.ExecuteNonQuery();
                        Logger.Info($"New account created for user: {username}");
                    }
                }

                MessageBox.Show("Account created successfully! Please log in.");

                this.DialogResult = DialogResult.OK; // tells Program.cs that creation is done
                this.Close();
            }
            catch (Exception ex)
            {
                Logger.Error($"Error creating account for {username}: {ex.Message}");
                MessageBox.Show("Error creating account: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}