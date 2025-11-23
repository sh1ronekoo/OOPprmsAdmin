using System;
using System.Collections.Generic;
using System.Windows.Forms;
using admindash.Core;

namespace admindash.Records_Dashboard
{
    // INHERITANCE: This is the parent class for all record forms.
    // It contains the logic shared by Accepted, Declined, All, etc.
    public partial class BaseAppointmentForm : Form
    {
        protected AppointmentService _service;
        protected int _selectedId = -1;

        public BaseAppointmentForm()
        {
            _service = new AppointmentService();
        }

        // Shared Logic: Populating the ListView
        protected void PopulateListView(ListView listView, List<Appointment> appointments)
        {
            listView.Items.Clear();
            foreach (var app in appointments)
            {
                ListViewItem item = new ListViewItem(app.AppointmentNumber.ToString());
                item.SubItems.Add(app.PatientName);
                item.SubItems.Add(app.FormattedDate);
                item.SubItems.Add(app.Status);
                listView.Items.Add(item);
            }
        }

        // Shared Logic: Handling selection
        protected void HandleSelectionChanged(ListView listView)
        {
            if (listView.SelectedItems.Count > 0)
            {
                _selectedId = Convert.ToInt32(listView.SelectedItems[0].SubItems[0].Text);
            }
            else
            {
                _selectedId = -1;
            }
        }

        // Shared Logic: Update Status Helper
        protected void PerformUpdate(string newStatus, Action refreshCallback)
        {
            if (_selectedId == -1)
            {
                MessageBox.Show("Please select an appointment first.");
                return;
            }

            bool success = _service.UpdateStatus(_selectedId, newStatus);
            if (success)
            {
                MessageBox.Show($"Appointment marked as {newStatus}.");
                refreshCallback?.Invoke();
            }
            else
            {
                MessageBox.Show("Failed to update status.");
            }
        }
    }
}