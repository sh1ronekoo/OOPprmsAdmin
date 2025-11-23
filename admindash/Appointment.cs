using System;

namespace admindash.Core
{
    // ENCAPSULATION: Data is bundled into an object instead of loose variables.
    public class Appointment
    {
        public int AppointmentNumber { get; set; }
        public string PatientName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Status { get; set; }

        public string FormattedDate => AppointmentDate.ToString("yyyy-MM-dd hh:mm tt");
    }
}