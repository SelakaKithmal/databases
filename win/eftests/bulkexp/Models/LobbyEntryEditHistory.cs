using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class LobbyEntryEditHistory
    {
        public long Id { get; set; }
        public long FkLobbyEntryId { get; set; }
        public int FkEditedById { get; set; }
        public DateTime EditedTime { get; set; }
        public bool IsDelete { get; set; }
        public string Reason { get; set; }

        public virtual User FkEditedBy { get; set; }
        public virtual LobbyEntry FkLobbyEntry { get; set; }
    }
}
