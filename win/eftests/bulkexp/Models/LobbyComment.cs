using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class LobbyComment
    {
        public int Id { get; set; }
        public long FkLobbyEntryId { get; set; }
        public int FkAddedBy { get; set; }
        public DateTime AddedTime { get; set; }
        public DateTime? LastUpdated { get; set; }
        public string Comment { get; set; }

        public virtual User FkAddedByNavigation { get; set; }
        public virtual LobbyEntry FkLobbyEntry { get; set; }
    }
}
