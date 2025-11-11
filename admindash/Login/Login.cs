using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace admindash
{
    public partial class Login : Form
    {
        string connectionString = "Server=oop-prms-iqperia06-3946oop.e.aivencloud.com;" +
                                  "Port=19631;" +
                                  "Database=oop_project;" +
                                  "User ID=avnadmin;" +
                                  "Password=AVNS_DC-Fjd1udeFkVwK429X;" +
                                  "SslMode=Required;";

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
                            MessageBox.Show("Login successful!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // VERY IMPORTANT: report success to Program.cs
                            this.DialogResult = DialogResult.OK;
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.",
                                "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
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
        }
    }
}
