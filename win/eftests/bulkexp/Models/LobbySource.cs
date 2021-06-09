using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class LobbySource
    {
        public LobbySource()
        {
            LobbyEntries = new HashSet<LobbyEntry>();
        }

        public int Id { get; set; }
        public string SourceName { get; set; }

        public virtual ICollection<LobbyEntry> LobbyEntries { get; set; }
    }
}
