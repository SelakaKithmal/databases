using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class NotificationMessageTemplate
    {
        public int TemplateId { get; set; }
        public string NotifyEvent { get; set; }
        public string SendVia { get; set; }
        public string Template { get; set; }
        public string CustomTemplate { get; set; }
    }
}
