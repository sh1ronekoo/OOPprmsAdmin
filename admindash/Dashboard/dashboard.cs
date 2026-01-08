using admindash.Dashboard;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace admindash
{
    public partial class dashboard : Form
    {
        // Keep a reference to MainDashboard
        private MainDashboard mainDash;

        public dashboard()
        {
            InitializeComponent();
            this.Load += dashboard_Load; // Make sure this event is wired
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            // Set Appointments button as active
            SetActiveButton(btnAppointments);

            // Create MainDashboard and show immediately
            mainDash = new MainDashboard();
            OpenChildForm(mainDash);
            mainDash.LoadAppointments();
        }

        private void SetActiveButton(Button activeBtn)
        {
            btnAppointments.BackColor = Color.FromArgb(142, 160, 185);
            btnRecords.BackColor = Color.FromArgb(142, 160, 185);
            btnReports.BackColor = Color.FromArgb(142, 160, 185);

            activeBtn.BackColor = Color.FromArgb(192, 210, 235);
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnAppointments);

            if (mainDash == null || mainDash.IsDisposed)
                mainDash = new MainDashboard();

            OpenChildForm(mainDash);
            mainDash.LoadAppointments();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnRecords);

            RecordsDashboard recordsDash = new RecordsDashboard();
            OpenChildForm(recordsDash);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnReports);

            ReportsDashboard reportsDash = new ReportsDashboard();
            OpenChildForm(reportsDash);
        }

        private void OpenChildForm(Form childForm)
        {
            panelContent.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Go back to Login
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
