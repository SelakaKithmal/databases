using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class MessageFormatType
    {
        public MessageFormatType()
        {
            MessageTemplates = new HashSet<MessageTemplate>();
        }

        public int MessageFormatTypeId { get; set; }
        public string MessageFormatTypeName { get; set; }

        public virtual ICollection<MessageTemplate> MessageTemplates { get; set; }
    }
}
