using admindash.Records_Dashboard;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace admindash.Dashboard
{
    public partial class RecordsDashboard : Form
    {
        private string connectionString = "Server=oop-prms-iqperia06-3946oop.e.aivencloud.com;" +
                                          "Port=19631;" +
                                          "Database=oop_project;" +
                                          "User ID=avnadmin;" +
                                          "Password=AVNS_DC-Fjd1udeFkVwK429X;" +
                                          "SslMode=Required;";

        public RecordsDashboard()
        {
            InitializeComponent();
            this.Load += RecordsDashboard_Load;   // ✅ THIS IS REQUIRED
        }

        private void RecordsDashboard_Load(object sender, EventArgs e)
        {
        }

        private void listViewRecords_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadFormInPanel(Form form)
        {
            // Clear previous form
            panel2.Controls.Clear();

            // Setup form for embedding
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Add to panel
            panel2.Controls.Add(form);
            panel2.Tag = form;
            form.Show();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            AllApp allForm = new AllApp();
            LoadFormInPanel(allForm);
        }

        private void btnAccepted_Click(object sender, EventArgs e)
        {
            AcceptedApp acceptedForm = new AcceptedApp();
            LoadFormInPanel(acceptedForm);
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            CompletedApp completedForm = new CompletedApp();
            LoadFormInPanel(completedForm);
        }

        private void btnCancelled_Click(object sender, EventArgs e)
        {
            CancelledApp cancelledForm = new CancelledApp();
            LoadFormInPanel(cancelledForm);
        }

        private void btnDeclined_Click(object sender, EventArgs e)
        {
            DeclinedApp declinedForm = new DeclinedApp();
            LoadFormInPanel(declinedForm);
        }

    }
}
