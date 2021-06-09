using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class LobbyServiceRequest
    {
        public long ServiceRequestId { get; set; }
        public long FkLobbyEntryId { get; set; }
        public int FkServiceId { get; set; }

        public virtual LobbyEntry FkLobbyEntry { get; set; }
        public virtual Service FkService { get; set; }
    }
}
