using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace admindash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // subscribe to logger events to show logs in UI
            Logger.LogAppended += Logger_LogAppended;

            this.Load += Form1_Load;
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            Logger.Info("Application starting");
            lblStatus.Text = "Application started";

            // populate a simple demo table
            var table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Role", typeof(string));
            table.Rows.Add(1, "Alice", "Admin");
            table.Rows.Add(2, "Bob", "User");
            table.Rows.Add(3, "Carol", "Viewer");
            dgvMain.DataSource = table;

            Logger.Info("Demo data loaded into grid");
            AppendLogToUI("Ready");
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Logger.Info("Application closing");
            Logger.LogAppended -= Logger_LogAppended;
        }

        private void Logger_LogAppended(string message)
        {
            AppendLogToUI(message);
        }

        private void AppendLogToUI(string message)
        {
            if (richTextBoxLogs.InvokeRequired)
            {
                richTextBoxLogs.BeginInvoke(new Action(() => AppendLogToUI(message)));
                return;
            }

            // keep logs reasonably sized in the UI
            const int maxLines = 1000;
            richTextBoxLogs.AppendText(message + Environment.NewLine);
            var lines = richTextBoxLogs.Lines;
            if (lines.Length > maxLines)
            {
                var newLines = new string[maxLines];
                Array.Copy(lines, lines.Length - maxLines, newLines, 0, maxLines);
                richTextBoxLogs.Lines = newLines;
            }

            // scroll to end
            richTextBoxLogs.SelectionStart = richTextBoxLogs.Text.Length;
            richTextBoxLogs.ScrollToCaret();
        }

        private void BtnDashboard_Click(object? sender, EventArgs e)
        {
            lblStatus.Text = "Dashboard";
            Logger.Info("Navigated to Dashboard");
            // for demo: highlight the grid and keep demo rows
            dgvMain.BackColor = SystemColors.Window;
        }

        private void BtnUsers_Click(object? sender, EventArgs e)
        {
            lblStatus.Text = "Users";
            Logger.Info("Navigated to Users");
            // for demo: change grid background to show state
            dgvMain.BackColor = Color.AliceBlue;
        }

        private void BtnSettings_Click(object? sender, EventArgs e)
        {
            lblStatus.Text = "Settings";
            Logger.Info("Navigated to Settings");
            // for demo: change grid background to show state
            dgvMain.BackColor = Color.Lavender;
        }

        private void TimerClock_Tick(object? sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        // Optionally, other helper methods can go here...
    }
}
