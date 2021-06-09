using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class CustomFieldValue
    {
        public int FkCustomFieldId { get; set; }
        public long FkEntityId { get; set; }
        public int FkAddedBy { get; set; }
        public int? FkUpdatedBy { get; set; }
        public string CustomFieldValue1 { get; set; }

        public virtual User FkAddedByNavigation { get; set; }
        public virtual CustomField FkCustomField { get; set; }
        public virtual User FkUpdatedByNavigation { get; set; }
    }
}
