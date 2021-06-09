using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class LobbyStatus
    {
        public LobbyStatus()
        {
            LobbyEntries = new HashSet<LobbyEntry>();
        }

        public int LobbyStatusId { get; set; }
        public string LobbyStatusName { get; set; }

        public virtual ICollection<LobbyEntry> LobbyEntries { get; set; }
    }
}
