using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class LobbyEntry
    {
        public LobbyEntry()
        {
            LobbyComments = new HashSet<LobbyComment>();
            LobbyEntryEditHistories = new HashSet<LobbyEntryEditHistory>();
            LobbyInteractions = new HashSet<LobbyInteraction>();
            LobbyServiceProvideds = new HashSet<LobbyServiceProvided>();
            LobbyServiceRequests = new HashSet<LobbyServiceRequest>();
        }

        public long LobbyEntryId { get; set; }
        public int FkLobbyId { get; set; }
        public int FkLobbySourceId { get; set; }
        public int? FkUserRequested { get; set; }
        public int FkAddedBy { get; set; }
        public int? FkUpdatedBy { get; set; }
        public int FkPreferredLanguage { get; set; }
        public int FkStatus { get; set; }
        public long? AppointmentId { get; set; }
        public string AccountNumber { get; set; }
        public string AccountNoLastFourDigits { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string Notes { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public bool RecieveTextMessage { get; set; }
        public bool IsActive { get; set; }
        public bool IsArchived { get; set; }
        public bool ClosedByAutoWrapUp { get; set; }
        public DateTime AddedTime { get; set; }
        public DateTime AddedLocalTime { get; set; }
        public DateTime? LastUpdated { get; set; }
        public DateTime? LastUpdatedLocalTime { get; set; }
        public DateTime VirtualAddedTimeForWaitCalculation { get; set; }
        public int? FkLwaReasonId { get; set; }

        public virtual Appointment Appointment { get; set; }
        public virtual User FkAddedByNavigation { get; set; }
        public virtual Lobby FkLobby { get; set; }
        public virtual LobbySource FkLobbySource { get; set; }
        public virtual Lwareason FkLwaReason { get; set; }
        public virtual Language FkPreferredLanguageNavigation { get; set; }
        public virtual LobbyStatus FkStatusNavigation { get; set; }
        public virtual User FkUpdatedByNavigation { get; set; }
        public virtual User FkUserRequestedNavigation { get; set; }
        public virtual ICollection<LobbyComment> LobbyComments { get; set; }
        public virtual ICollection<LobbyEntryEditHistory> LobbyEntryEditHistories { get; set; }
        public virtual ICollection<LobbyInteraction> LobbyInteractions { get; set; }
        public virtual ICollection<LobbyServiceProvided> LobbyServiceProvideds { get; set; }
        public virtual ICollection<LobbyServiceRequest> LobbyServiceRequests { get; set; }
    }
}
