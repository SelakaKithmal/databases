using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class QueueStrategy
    {
        public QueueStrategy()
        {
            Lobbies = new HashSet<Lobby>();
        }

        public int Id { get; set; }
        public string Strategy { get; set; }

        public virtual ICollection<Lobby> Lobbies { get; set; }
    }
}
