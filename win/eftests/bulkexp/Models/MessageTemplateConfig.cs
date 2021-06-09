using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class MessageTemplateConfig
    {
        public int MessageTemplateConfigId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
