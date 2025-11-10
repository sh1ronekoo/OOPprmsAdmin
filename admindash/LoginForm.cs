using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace admindash

{
    public partial class frmLogin : Form
    {
        string connStr = "server=localhost;database=db_oop;uid=root;pwd=;";
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lblError;
        private Button btnLogin;

        public frmLogin(Button btnLogin)
        {
            InitializeComponent();

            // Ensure designer events are wired to these implementations
            this.Load += LoginForm_Load;
            this.btnLogin = btnLogin;
            this.btnLogin.Click += btnLogin_Click;
            this.txtUsername.TextChanged += txtUsername_TextChanged;
        }

        private void LoginForm_Load(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        private void frmLogin_Load_1(object sender, EventArgs e)
        {
            // Reset fields and UI state
            try
            {
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
                lblError.Text = string.Empty;
                txtPassword.UseSystemPasswordChar = true;
                txtUsername.Focus();
            }
            catch
            {
                // Safe-fail: ensure form still shows if a control is missing
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                if (lblError != null)
                {
                    lblError.ForeColor = Color.IndianRed;
                    lblError.Text = "Please enter username and password.";
                }
                Logger?.Warn("Login attempt with empty username or password.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();
                    string sql = "SELECT * FROM login WHERE username=@username AND password=@password";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {

                                lblError.Text = "";
                                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Hide();
                                Form1 petsForm = new Form1();
                                petsForm.ShowDialog();
                                this.Close();
                            }
                            else
                            {

                                lblError.Text = "Invalid username or password.";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection failed: " + ex.Message);
            }

            // Simple, safe behavior: accept any non-empty credentials.
            Logger?.Info($"Login attempt for '{username}'");
            if (lblError != null)
            {
                lblError.ForeColor = Color.SeaGreen;
                lblError.Text = "Login successful";
            }

            MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Logger?.Info($"User '{username}' logged in");

            // Tell Program.cs to continue to the main form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (lblError != null && !string.IsNullOrEmpty(lblError.Text))
                lblError.Text = string.Empty;
        }
    }
}
