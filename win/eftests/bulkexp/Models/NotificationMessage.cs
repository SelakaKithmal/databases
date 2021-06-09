using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class NotificationMessage
    {
        public int Id { get; set; }
        public short FkAlertViaId { get; set; }
        public int FkStatusId { get; set; }
        public string Recipient { get; set; }
        public string Message { get; set; }
        public int Attempts { get; set; }
        public DateTime AddedTime { get; set; }
        public DateTime? SentTime { get; set; }
        public DateTime LastAttemptTime { get; set; }
        public string Entity { get; set; }
        public string EntityId { get; set; }

        public virtual AlertVium FkAlertVia { get; set; }
        public virtual NotificationMessageStatus FkStatus { get; set; }
    }
}
