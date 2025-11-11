using admindash.Dashboard;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace admindash
{
    public partial class dashboard : Form
    {

        public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            MainDashboard mainDash = new MainDashboard();
            OpenChildForm(mainDash);
        }

        private void SetActiveButton(Button activeBtn)
        {
            btnAppointments.BackColor = Color.FromArgb(142, 160, 185);
            btnRecords.BackColor = Color.FromArgb(142, 160, 185);
            btnReports.BackColor = Color.FromArgb(142, 160, 185);

            activeBtn.BackColor = Color.FromArgb(192, 210, 235);
        }

        // Button click events

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnAppointments);

            MainDashboard mainDash = new MainDashboard();
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
            panelContent.Controls.Clear(); // remove any existing child form
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
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
