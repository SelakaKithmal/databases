using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class Lwareason
    {
        public Lwareason()
        {
            LobbyEntries = new HashSet<LobbyEntry>();
        }

        public int LwareasonId { get; set; }
        public int? FkLocationId { get; set; }
        public string Reason { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ChangedBy { get; set; }
        public DateTime? ChangedDate { get; set; }

        public virtual User ChangedByNavigation { get; set; }
        public virtual User CreatedByNavigation { get; set; }
        public virtual ICollection<LobbyEntry> LobbyEntries { get; set; }
    }
}
