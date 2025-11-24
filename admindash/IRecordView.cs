using System;

namespace admindash.Core
{
    // Interface to allow the parent Dashboard to talk to all child forms
    public interface IRecordView
    {
        int GetSelectedAppointmentId();
        void RefreshData();
    }
}