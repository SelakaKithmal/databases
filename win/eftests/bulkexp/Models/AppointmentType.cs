using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class AppointmentType
    {
        public AppointmentType()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int AppointmentTypeId { get; set; }
        public string AppointmentTypeName { get; set; }
        public string ColorCode { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
