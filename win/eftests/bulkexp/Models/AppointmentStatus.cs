using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class AppointmentStatus
    {
        public AppointmentStatus()
        {
            Appointments = new HashSet<Appointment>();
            Locations = new HashSet<Location>();
        }

        public int AppointmentStatusId { get; set; }
        public string AppointmentStatusName { get; set; }
        public string LocalizedKey { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
    }
}
