using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class MessageType
    {
        public MessageType()
        {
            MessageTemplates = new HashSet<MessageTemplate>();
        }

        public int MessageTypeId { get; set; }
        public string MessageTypeName { get; set; }

        public virtual ICollection<MessageTemplate> MessageTemplates { get; set; }
    }
}
