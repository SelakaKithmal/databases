using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class CustomField
    {
        public CustomField()
        {
            CustomFieldValues = new HashSet<CustomFieldValue>();
        }

        public int CustomFieldId { get; set; }
        public string TableName { get; set; }
        public string Type { get; set; }
        public string FieldName { get; set; }
        public bool? CustomFieldEnabled { get; set; }
        public string MetaData { get; set; }

        public virtual ICollection<CustomFieldValue> CustomFieldValues { get; set; }
    }
}
