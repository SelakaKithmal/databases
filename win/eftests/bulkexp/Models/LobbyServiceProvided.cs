using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class LobbyServiceProvided
    {
        public long ServiceProvidedId { get; set; }
        public long FkLobbyEntryId { get; set; }
        public long FkLobbyInteractionId { get; set; }
        public int FkServiceId { get; set; }
        public int ServiceTime { get; set; }
        public string ReferenceNumber { get; set; }
        public DateTime ServiceProvidedTime { get; set; }
        public DateTime? LastUpdatedTime { get; set; }

        public virtual LobbyEntry FkLobbyEntry { get; set; }
        public virtual LobbyInteraction FkLobbyInteraction { get; set; }
        public virtual Service FkService { get; set; }
    }
}
