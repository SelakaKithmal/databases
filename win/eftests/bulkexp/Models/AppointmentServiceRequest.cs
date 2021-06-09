using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class AppointmentServiceRequest
    {
        public int AppointmentServiceRequestId { get; set; }
        public long FkAppointmentId { get; set; }
        public int FkServiceId { get; set; }
        public int? ChangedBy { get; set; }
        public DateTime? ChangedDate { get; set; }

        public virtual User ChangedByNavigation { get; set; }
        public virtual Appointment FkAppointment { get; set; }
        public virtual Service FkService { get; set; }
    }
}
