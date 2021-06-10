using bulkexp.Types;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bulkexp.Mappings
{
    class LocationMap : ClassMap<LocationsDTO>
    {
        public LocationMap()
        {
            Map(m => m.ActiveStatus).Name("Active Status");
            Map(m => m.Address1).Name("Address Line 1");
            Map(m => m.Address2).Name("Address Line 2");
            Map(m => m.AllowRemoteCheckIn).Name("Allow remote check-in");
            Map(m => m.AllowRequestStaff).Name("Allow request staff");
            Map(m => m.AppointmentCutoffWindow).Name("Appointment Cutoff Window");
            Map(m => m.AutoWrapUpTime).Name("Auto-Wrap Time");
            Map(m => m.AutoWrapUpApptStatus).Name("Appointment status to change");
            Map(m => m.ChangeApptStatus).Name("Change Appointemnt Status");
            Map(m => m.CheckInLeadTime).Name("Check In Lead Time");
            Map(m => m.City).Name("City"); 
            Map(m => m.Color).Name("Location Color");
            Map(m => m.Country).Name("Country");
            Map(m => m.CutOffBeforeClosing).Name("Cutoff Before Closing");
            Map(m => m.Email).Name("Email");
            Map(m => m.FloatPriorityMode).Name("Float Priority Mode");
            Map(m => m.FutureAvailabilityWindow).Name("Future Availability Window");
            Map(m => m.Latitude).Name("Latitude");
            Map(m => m.LeadTimeAppointmentBooking).Name("Lead time for appointment booking");
            Map(m => m.LocationCode).Name("Location Code");
            Map(m => m.LocationDisplayName).Name("Location Display Name");
            Map(m => m.LocationName).Name("Location Name");
            Map(m => m.LocationType).Name("Location Type");
            Map(m => m.Longitude).Name("Longitude");
            Map(m => m.ParentLocationCode).Name("Parent Location Code");
            Map(m => m.PhoneExt).Name("Phone Ext.");
            Map(m => m.PhoneNumber).Name("Phone Number");
            Map(m => m.ReminderEmailNotificationTime).Name("Reminder Email Notification Time");
            Map(m => m.ReminderTextMessageNotificationTime).Name("Reminder text message notification time");
            Map(m => m.ShowInWidget).Name("Show in widget");
            Map(m => m.State).Name("State");
            Map(m => m.SummaryEmailNotificationTime).Name("Summary Email Notification Time");
            Map(m => m.Timezone).Name("Timezone");
            Map(m => m.UseAppointment).Name("Use Appointments");
            Map(m => m.ZipCode).Name("Zip Code");
        }
    }
}
