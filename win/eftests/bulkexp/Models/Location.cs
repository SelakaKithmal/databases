using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class Location
    {
        public Location()
        {
            Appointments = new HashSet<Appointment>();
            Holidays = new HashSet<Holiday>();
            InverseFkParentLocation = new HashSet<Location>();
            Lobbies = new HashSet<Lobby>();
            LocationHierarchyParentLocations = new HashSet<LocationHierarchy>();
            LocationHoursOfOperations = new HashSet<LocationHoursOfOperation>();
            LocationServices = new HashSet<LocationService>();
            MessageTemplates = new HashSet<MessageTemplate>();
            UserFkDefaultLocations = new HashSet<User>();
            UserFkHomeLocations = new HashSet<User>();
            UserSignIns = new HashSet<UserSignIn>();
            UserWorkLocations = new HashSet<UserWorkLocation>();
            WorkAvailTemplateTimeRanges = new HashSet<WorkAvailTemplateTimeRange>();
            WorkAvailTemplates = new HashSet<WorkAvailTemplate>();
        }

        public int LocationId { get; set; }
        public int? FkParentLocationId { get; set; }
        public int FkLocationTypeId { get; set; }
        public int FkTimeZoneId { get; set; }
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
        public string FaxNumber { get; set; }
        public string Email { get; set; }
        public decimal? Longitude { get; set; }
        public decimal? Latitude { get; set; }
        public bool? UseAppointments { get; set; }
        public int AvailabilityWindowDays { get; set; }
        public int AppointmentCutOffDays { get; set; }
        public TimeSpan DailySummaryEmailTime { get; set; }
        public decimal DurationBeforeFirstApptHours { get; set; }
        public decimal ReminderBeforeApptSmsHours { get; set; }
        public decimal ReminderBeforeApptEmailHours { get; set; }
        public byte ActiveStatus { get; set; }
        public bool EnableStaffSelection { get; set; }
        public bool? ShowInWidget { get; set; }
        public byte AutoAssignFloatPriorityMode { get; set; }
        public string PhoneExtention { get; set; }
        public bool GoogleReserveEnabled { get; set; }
        public TimeSpan AutoWrapupTime { get; set; }
        public bool ChangeApptStatus { get; set; }
        public int? AutoWrapupApptStatus { get; set; }
        public string Color { get; set; }
        public bool? OnlineCheckInEnabled { get; set; }
        public TimeSpan TimeBeforeBranchCloseForOnlineCheckIn { get; set; }
        public TimeSpan TimeInAdvanceForOnlineCheckIn { get; set; }
        public int? BranchId { get; set; }
        public int? RegionId { get; set; }
        public int? OldLocationId { get; set; }
        public int? OldParentLocationId { get; set; }
        public int? FkRegionId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ChangedBy { get; set; }
        public DateTime? ChangedDate { get; set; }

        public virtual AppointmentStatus AutoWrapupApptStatusNavigation { get; set; }
        public virtual User ChangedByNavigation { get; set; }
        public virtual User CreatedByNavigation { get; set; }
        public virtual LocationType FkLocationType { get; set; }
        public virtual Location FkParentLocation { get; set; }
        public virtual TimeZone FkTimeZone { get; set; }
        public virtual KioskConfiguration KioskConfiguration { get; set; }
        public virtual LocationHierarchy LocationHierarchyLocation { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Holiday> Holidays { get; set; }
        public virtual ICollection<Location> InverseFkParentLocation { get; set; }
        public virtual ICollection<Lobby> Lobbies { get; set; }
        public virtual ICollection<LocationHierarchy> LocationHierarchyParentLocations { get; set; }
        public virtual ICollection<LocationHoursOfOperation> LocationHoursOfOperations { get; set; }
        public virtual ICollection<LocationService> LocationServices { get; set; }
        public virtual ICollection<MessageTemplate> MessageTemplates { get; set; }
        public virtual ICollection<User> UserFkDefaultLocations { get; set; }
        public virtual ICollection<User> UserFkHomeLocations { get; set; }
        public virtual ICollection<UserSignIn> UserSignIns { get; set; }
        public virtual ICollection<UserWorkLocation> UserWorkLocations { get; set; }
        public virtual ICollection<WorkAvailTemplateTimeRange> WorkAvailTemplateTimeRanges { get; set; }
        public virtual ICollection<WorkAvailTemplate> WorkAvailTemplates { get; set; }
    }
}
