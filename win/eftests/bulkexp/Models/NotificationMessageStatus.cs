using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class NotificationMessageStatus
    {
        public NotificationMessageStatus()
        {
            NotificationMessages = new HashSet<NotificationMessage>();
        }

        public int Id { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<NotificationMessage> NotificationMessages { get; set; }
    }
}
