using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class KioskConfiguration
    {
        public int FkLocationId { get; set; }
        public bool ShowAccountNumber { get; set; }
        public bool ShowPhoneNumber { get; set; }
        public bool ShowEmailAddress { get; set; }
        public bool ShowDateOfBirth { get; set; }
        public bool ShowCustomField1 { get; set; }
        public bool ShowPersonRequested { get; set; }
        public bool ShowServiceRequested { get; set; }
        public bool ShowServiceRequestedCategorized { get; set; }
        public bool ShowGroupRequested { get; set; }
        public bool ShowSpanishSpeaker { get; set; }
        public bool ShowChangeLanguageOption { get; set; }
        public bool ShowWaitTimeVisitorsInHome { get; set; }
        public bool ShowWaitTimePositionInConfirmation { get; set; }
        public bool ShowBookAppointmentTab { get; set; }
        public bool ShowCheckinAppointmentTab { get; set; }
        public bool ShowSignInForCheckinTab { get; set; }
        public bool IsProductServiceSelectionMandatory { get; set; }
        public int RefreshRateSeconds { get; set; }
        public int LastPageRefreshRateSeconds { get; set; }
        public string DefaultSelectedPersonOrGroup { get; set; }
        public int? DefaultNotificationGroup { get; set; }
        public Guid LocalizedRowId { get; set; }
        public string SortServiceListBy { get; set; }
        public string FontSize { get; set; }
        public string DefaultWelcomeText { get; set; }
        public string DefaultThankyouText { get; set; }
        public string WaitOption { get; set; }
        public int WaitValue { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int? ChangedBy { get; set; }
        public DateTime? ChangedByDateTime { get; set; }

        public virtual User ChangedByNavigation { get; set; }
        public virtual User CreatedByNavigation { get; set; }
        public virtual Location FkLocation { get; set; }
    }
}
