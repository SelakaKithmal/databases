using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class AlertVium
    {
        public AlertVium()
        {
            NotificationMessages = new HashSet<NotificationMessage>();
        }

        public short AlertViaId { get; set; }
        public string AlertVia { get; set; }

        public virtual ICollection<NotificationMessage> NotificationMessages { get; set; }
    }
}
