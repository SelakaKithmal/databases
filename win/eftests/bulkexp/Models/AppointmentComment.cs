using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class AppointmentComment
    {
        public int AppointmentCommentId { get; set; }
        public long? FkAppointmentId { get; set; }
        public string Comment { get; set; }
        public int? ChangedBy { get; set; }
        public DateTime? ChangedDate { get; set; }

        public virtual User ChangedByNavigation { get; set; }
        public virtual Appointment FkAppointment { get; set; }
    }
}
