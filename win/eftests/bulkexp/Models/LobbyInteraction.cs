using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class LobbyInteraction
    {
        public LobbyInteraction()
        {
            LobbyServiceProvideds = new HashSet<LobbyServiceProvided>();
        }

        public long InteractionId { get; set; }
        public long FkLobbyEntryId { get; set; }
        public int FkAssistTypeId { get; set; }
        public int FkAssistedBy { get; set; }
        public long FkAssistedUserSession { get; set; }
        public DateTime AssistedTime { get; set; }
        public DateTime AssistedLocalTime { get; set; }
        public DateTime? CompletedTime { get; set; }
        public DateTime? CompletedLocalTime { get; set; }
        public double Duration { get; set; }

        public virtual AssistType FkAssistType { get; set; }
        public virtual User FkAssistedByNavigation { get; set; }
        public virtual UserSignIn FkAssistedUserSessionNavigation { get; set; }
        public virtual LobbyEntry FkLobbyEntry { get; set; }
        public virtual ICollection<LobbyServiceProvided> LobbyServiceProvideds { get; set; }
    }
}
