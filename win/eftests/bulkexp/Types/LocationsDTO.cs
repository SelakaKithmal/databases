using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bulkexp.Types
{
    public enum FloatPriority
    {
        HomeEmployeesFirst=1,
        EqualPriority=2,
        FloatEmployeesFirst=3
    }

    public class LocationsDTO
    {
        public string ParentLocationCode { get; set; }
        public string LocationType { get; set; }
        public string Timezone { get; set; }
        public string LocationName { get; set; }
        public string LocationDisplayName { get; set; }
        public string LocationCode { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public bool UseAppointment { get; set; }
        public int FutureAvailabilityWindow { get; set; }
        public int AppointmentCutoffWindow { get; set; }
        public TimeSpan SummaryEmailNotificationTime { get; set; }
        public TimeSpan CutOffBeforeClosing { get; set; }
        public decimal LeadTimeAppointmentBooking { get; set; }
        public decimal ReminderTextMessageNotificationTime { get; set; }
        public decimal ReminderEmailNotificationTime { get; set; }
        public bool ActiveStatus { get; set; }
        public bool AllowRequestStaff { get; set; }
        public bool ShowInWidget { get; set; }
        public FloatPriority FloatPriorityMode { get; set; }
        public string PhoneExt { get; set; }
        public TimeSpan AutoWrapUpTime { get; set; }
        public bool ChangeApptStatus { get; set; }
        public string AutoWrapUpApptStatus { get; set; }
        public string Color { get; set; }
        public bool AllowRemoteCheckIn { get; set; }
        public TimeSpan CheckInLeadTime { get; set; }

        public string[] GetRGB()
        {
            return this.Color.Substring(4).Split(')')[0].Split(',');
        }
    }
}
