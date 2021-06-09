using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class Appointment
    {
        public Appointment()
        {
            AppointmentComments = new HashSet<AppointmentComment>();
            AppointmentServiceRequests = new HashSet<AppointmentServiceRequest>();
            LobbyEntries = new HashSet<LobbyEntry>();
        }

        public long AppointmentId { get; set; }
        public int? OldAppointmentId { get; set; }
        public int? FkAssignedUserId { get; set; }
        public int? FkLocationId { get; set; }
        public int FkAppointmentTypeId { get; set; }
        public int FkAppointmentStatusId { get; set; }
        public string ConfirmationNumber { get; set; }
        public DateTime StartTime { get; set; }
        public int StartTimeUtcOffset { get; set; }
        public DateTime EndTime { get; set; }
        public int EndTimeUtcOffset { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public bool SmsReminder { get; set; }
        public string Email { get; set; }
        public bool EmailReminder { get; set; }
        public string CustomerNotes { get; set; }
        public DateTime? OltcheckInTime { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ChangedBy { get; set; }
        public DateTime? ChangedDate { get; set; }
        public byte ActiveStatus { get; set; }
        public bool? SpanishRequested { get; set; }
        public bool? DisableCancellation { get; set; }
        public bool IsPhoneOnly { get; set; }
        public bool IsFloat { get; set; }
        public string ExtCustomerId { get; set; }
        public int FkSourceTypeId { get; set; }
        public bool AutoAssigned { get; set; }
        public bool? FixedStaff { get; set; }
        public int? OldLtappointmentId { get; set; }

        public virtual User ChangedByNavigation { get; set; }
        public virtual User CreatedByNavigation { get; set; }
        public virtual AppointmentStatus FkAppointmentStatus { get; set; }
        public virtual AppointmentType FkAppointmentType { get; set; }
        public virtual User FkAssignedUser { get; set; }
        public virtual Location FkLocation { get; set; }
        public virtual SourceType FkSourceType { get; set; }
        public virtual ICollection<AppointmentComment> AppointmentComments { get; set; }
        public virtual ICollection<AppointmentServiceRequest> AppointmentServiceRequests { get; set; }
        public virtual ICollection<LobbyEntry> LobbyEntries { get; set; }
    }
}
