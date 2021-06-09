using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class MessageTemplate
    {
        public int MessageTemplateId { get; set; }
        public int FkMessageFormatTypeId { get; set; }
        public int FkMessageTypeId { get; set; }
        public int FkLocationId { get; set; }
        public string MessageTemplateBody { get; set; }
        public string MessageSubject { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ChangedBy { get; set; }
        public DateTime? ChangedDate { get; set; }
        public byte ActiveStatus { get; set; }

        public virtual User ChangedByNavigation { get; set; }
        public virtual User CreatedByNavigation { get; set; }
        public virtual Location FkLocation { get; set; }
        public virtual MessageFormatType FkMessageFormatType { get; set; }
        public virtual MessageType FkMessageType { get; set; }
    }
}
