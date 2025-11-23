using admindash.Records_Dashboard;
using System;
using System.Windows.Forms;

namespace admindash.Dashboard
{
    public partial class RecordsDashboard : Form
    {
        // Connection string removed: This form purely handles navigation.

        public RecordsDashboard()
        {
            InitializeComponent();
            this.Load += RecordsDashboard_Load;
        }

        private void RecordsDashboard_Load(object sender, EventArgs e)
        {
        }

        private void LoadFormInPanel(Form form)
        {
            panel2.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel2.Controls.Add(form);
            panel2.Tag = form;
            form.Show();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new AllApp());
        }

        private void btnAccepted_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new AcceptedApp());
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new CompletedApp());
        }

        private void btnCancelled_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new CancelledApp());
        }

        private void btnDeclined_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new DeclinedApp());
        }

        private void listViewRecords_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}