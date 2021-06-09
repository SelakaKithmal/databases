using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class QueueConfiguration
    {
        public int Id { get; set; }
        public string QueueName { get; set; }
        public int Priority { get; set; }
        public int FkLobbyId { get; set; }
        public string WaitOption { get; set; }
        public int WaitVisitorsOrHours { get; set; }

        public virtual Lobby FkLobby { get; set; }
    }
}
