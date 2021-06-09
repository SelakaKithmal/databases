using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class Lobby
    {
        public Lobby()
        {
            LobbyEntries = new HashSet<LobbyEntry>();
            QueueConfigurations = new HashSet<QueueConfiguration>();
            UserSignIns = new HashSet<UserSignIn>();
        }

        public int Id { get; set; }
        public int FkLocationId { get; set; }
        public string Name { get; set; }
        public int? FkQueueStrategyId { get; set; }

        public virtual Location FkLocation { get; set; }
        public virtual QueueStrategy FkQueueStrategy { get; set; }
        public virtual ICollection<LobbyEntry> LobbyEntries { get; set; }
        public virtual ICollection<QueueConfiguration> QueueConfigurations { get; set; }
        public virtual ICollection<UserSignIn> UserSignIns { get; set; }
    }
}
