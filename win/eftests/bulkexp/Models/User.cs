using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class User
    {
        public User()
        {
            AppointmentChangedByNavigations = new HashSet<Appointment>();
            AppointmentComments = new HashSet<AppointmentComment>();
            AppointmentCreatedByNavigations = new HashSet<Appointment>();
            AppointmentFkAssignedUsers = new HashSet<Appointment>();
            AppointmentServiceRequests = new HashSet<AppointmentServiceRequest>();
            AuditLogs = new HashSet<AuditLog>();
            ChecklistChangedByNavigations = new HashSet<Checklist>();
            ChecklistCreatedByNavigations = new HashSet<Checklist>();
            CustomFieldValueFkAddedByNavigations = new HashSet<CustomFieldValue>();
            CustomFieldValueFkUpdatedByNavigations = new HashSet<CustomFieldValue>();
            HolidayChangedByNavigations = new HashSet<Holiday>();
            HolidayCreatedByNavigations = new HashSet<Holiday>();
            InverseChangedByNavigation = new HashSet<User>();
            InverseCreatedByNavigation = new HashSet<User>();
            InverseFkSupervisor = new HashSet<User>();
            KioskConfigurationChangedByNavigations = new HashSet<KioskConfiguration>();
            KioskConfigurationCreatedByNavigations = new HashSet<KioskConfiguration>();
            LobbyComments = new HashSet<LobbyComment>();
            LobbyEntryEditHistories = new HashSet<LobbyEntryEditHistory>();
            LobbyEntryFkAddedByNavigations = new HashSet<LobbyEntry>();
            LobbyEntryFkUpdatedByNavigations = new HashSet<LobbyEntry>();
            LobbyEntryFkUserRequestedNavigations = new HashSet<LobbyEntry>();
            LobbyInteractions = new HashSet<LobbyInteraction>();
            LocalizedTextChangedByNavigations = new HashSet<LocalizedText>();
            LocalizedTextCreatedByNavigations = new HashSet<LocalizedText>();
            LocationChangedByNavigations = new HashSet<Location>();
            LocationCreatedByNavigations = new HashSet<Location>();
            LocationHoursOfOperationChangedByNavigations = new HashSet<LocationHoursOfOperation>();
            LocationHoursOfOperationCreatedByNavigations = new HashSet<LocationHoursOfOperation>();
            LwareasonChangedByNavigations = new HashSet<Lwareason>();
            LwareasonCreatedByNavigations = new HashSet<Lwareason>();
            MessageTemplateChangedByNavigations = new HashSet<MessageTemplate>();
            MessageTemplateCreatedByNavigations = new HashSet<MessageTemplate>();
            PermissionChangedByNavigations = new HashSet<Permission>();
            PermissionCreatedByNavigations = new HashSet<Permission>();
            RoleChangedByNavigations = new HashSet<Role>();
            RoleCreatedByNavigations = new HashSet<Role>();
            ServiceChangedByNavigations = new HashSet<Service>();
            ServiceCreatedByNavigations = new HashSet<Service>();
            UserHoursOfOperationChangedByNavigations = new HashSet<UserHoursOfOperation>();
            UserHoursOfOperationCreatedByNavigations = new HashSet<UserHoursOfOperation>();
            UserHoursOfOperationFkUsers = new HashSet<UserHoursOfOperation>();
            UserRoleCreatedByNavigations = new HashSet<UserRole>();
            UserRoleFkUsers = new HashSet<UserRole>();
            UserServiceChangedByNavigations = new HashSet<UserService>();
            UserServiceCreatedByNavigations = new HashSet<UserService>();
            UserServiceFkUsers = new HashSet<UserService>();
            UserSignIns = new HashSet<UserSignIn>();
            UserWorkLocations = new HashSet<UserWorkLocation>();
            WorkAvailTemplateChangedByNavigations = new HashSet<WorkAvailTemplate>();
            WorkAvailTemplateCreatedByNavigations = new HashSet<WorkAvailTemplate>();
            WorkAvailTemplateDays = new HashSet<WorkAvailTemplateDay>();
            WorkAvailTemplateFkUsers = new HashSet<WorkAvailTemplate>();
            WorkAvailTemplateTimeRanges = new HashSet<WorkAvailTemplateTimeRange>();
        }

        public int UserId { get; set; }
        public int? FkSupervisorId { get; set; }
        public int FkHomeLocationId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserCode { get; set; }
        public string PrimaryEmail { get; set; }
        public string SecondaryEmail { get; set; }
        public string PhoneNumber { get; set; }
        public bool? IsActive { get; set; }
        public bool IsFloat { get; set; }
        public bool IsSpanishSpeaker { get; set; }
        public bool? ShowInKiosk { get; set; }
        public bool? ShowInLobby { get; set; }
        public bool AppointmentsEnabled { get; set; }
        public bool EventsEnabled { get; set; }
        public bool VirtualAppointmentsEnabled { get; set; }
        public bool IsSupervisor { get; set; }
        public int? AssignmentRank { get; set; }
        public bool OptInDailyUserSummaryEmail { get; set; }
        public bool OptInDailyLocationSummaryEmail { get; set; }
        public int FkUserTypeId { get; set; }
        public int FkPreferredLanguageId { get; set; }
        public int? FkPreferredTimeZoneId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ChangedBy { get; set; }
        public DateTime? ChangedDate { get; set; }
        public int? FkDefaultLocationId { get; set; }
        public string ExternalUserId { get; set; }
        public int? OldAcId { get; set; }
        public int? OldLtid { get; set; }

        public virtual User ChangedByNavigation { get; set; }
        public virtual User CreatedByNavigation { get; set; }
        public virtual Location FkDefaultLocation { get; set; }
        public virtual Location FkHomeLocation { get; set; }
        public virtual Language FkPreferredLanguage { get; set; }
        public virtual TimeZone FkPreferredTimeZone { get; set; }
        public virtual User FkSupervisor { get; set; }
        public virtual UserType FkUserType { get; set; }
        public virtual ICollection<Appointment> AppointmentChangedByNavigations { get; set; }
        public virtual ICollection<AppointmentComment> AppointmentComments { get; set; }
        public virtual ICollection<Appointment> AppointmentCreatedByNavigations { get; set; }
        public virtual ICollection<Appointment> AppointmentFkAssignedUsers { get; set; }
        public virtual ICollection<AppointmentServiceRequest> AppointmentServiceRequests { get; set; }
        public virtual ICollection<AuditLog> AuditLogs { get; set; }
        public virtual ICollection<Checklist> ChecklistChangedByNavigations { get; set; }
        public virtual ICollection<Checklist> ChecklistCreatedByNavigations { get; set; }
        public virtual ICollection<CustomFieldValue> CustomFieldValueFkAddedByNavigations { get; set; }
        public virtual ICollection<CustomFieldValue> CustomFieldValueFkUpdatedByNavigations { get; set; }
        public virtual ICollection<Holiday> HolidayChangedByNavigations { get; set; }
        public virtual ICollection<Holiday> HolidayCreatedByNavigations { get; set; }
        public virtual ICollection<User> InverseChangedByNavigation { get; set; }
        public virtual ICollection<User> InverseCreatedByNavigation { get; set; }
        public virtual ICollection<User> InverseFkSupervisor { get; set; }
        public virtual ICollection<KioskConfiguration> KioskConfigurationChangedByNavigations { get; set; }
        public virtual ICollection<KioskConfiguration> KioskConfigurationCreatedByNavigations { get; set; }
        public virtual ICollection<LobbyComment> LobbyComments { get; set; }
        public virtual ICollection<LobbyEntryEditHistory> LobbyEntryEditHistories { get; set; }
        public virtual ICollection<LobbyEntry> LobbyEntryFkAddedByNavigations { get; set; }
        public virtual ICollection<LobbyEntry> LobbyEntryFkUpdatedByNavigations { get; set; }
        public virtual ICollection<LobbyEntry> LobbyEntryFkUserRequestedNavigations { get; set; }
        public virtual ICollection<LobbyInteraction> LobbyInteractions { get; set; }
        public virtual ICollection<LocalizedText> LocalizedTextChangedByNavigations { get; set; }
        public virtual ICollection<LocalizedText> LocalizedTextCreatedByNavigations { get; set; }
        public virtual ICollection<Location> LocationChangedByNavigations { get; set; }
        public virtual ICollection<Location> LocationCreatedByNavigations { get; set; }
        public virtual ICollection<LocationHoursOfOperation> LocationHoursOfOperationChangedByNavigations { get; set; }
        public virtual ICollection<LocationHoursOfOperation> LocationHoursOfOperationCreatedByNavigations { get; set; }
        public virtual ICollection<Lwareason> LwareasonChangedByNavigations { get; set; }
        public virtual ICollection<Lwareason> LwareasonCreatedByNavigations { get; set; }
        public virtual ICollection<MessageTemplate> MessageTemplateChangedByNavigations { get; set; }
        public virtual ICollection<MessageTemplate> MessageTemplateCreatedByNavigations { get; set; }
        public virtual ICollection<Permission> PermissionChangedByNavigations { get; set; }
        public virtual ICollection<Permission> PermissionCreatedByNavigations { get; set; }
        public virtual ICollection<Role> RoleChangedByNavigations { get; set; }
        public virtual ICollection<Role> RoleCreatedByNavigations { get; set; }
        public virtual ICollection<Service> ServiceChangedByNavigations { get; set; }
        public virtual ICollection<Service> ServiceCreatedByNavigations { get; set; }
        public virtual ICollection<UserHoursOfOperation> UserHoursOfOperationChangedByNavigations { get; set; }
        public virtual ICollection<UserHoursOfOperation> UserHoursOfOperationCreatedByNavigations { get; set; }
        public virtual ICollection<UserHoursOfOperation> UserHoursOfOperationFkUsers { get; set; }
        public virtual ICollection<UserRole> UserRoleCreatedByNavigations { get; set; }
        public virtual ICollection<UserRole> UserRoleFkUsers { get; set; }
        public virtual ICollection<UserService> UserServiceChangedByNavigations { get; set; }
        public virtual ICollection<UserService> UserServiceCreatedByNavigations { get; set; }
        public virtual ICollection<UserService> UserServiceFkUsers { get; set; }
        public virtual ICollection<UserSignIn> UserSignIns { get; set; }
        public virtual ICollection<UserWorkLocation> UserWorkLocations { get; set; }
        public virtual ICollection<WorkAvailTemplate> WorkAvailTemplateChangedByNavigations { get; set; }
        public virtual ICollection<WorkAvailTemplate> WorkAvailTemplateCreatedByNavigations { get; set; }
        public virtual ICollection<WorkAvailTemplateDay> WorkAvailTemplateDays { get; set; }
        public virtual ICollection<WorkAvailTemplate> WorkAvailTemplateFkUsers { get; set; }
        public virtual ICollection<WorkAvailTemplateTimeRange> WorkAvailTemplateTimeRanges { get; set; }
    }
}
