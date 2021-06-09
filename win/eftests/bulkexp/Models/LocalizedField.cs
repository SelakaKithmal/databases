using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class LocalizedField
    {
        public LocalizedField()
        {
            LocalizedTexts = new HashSet<LocalizedText>();
        }

        public int LocalizedFieldId { get; set; }
        public string LocalizedFieldName { get; set; }

        public virtual ICollection<LocalizedText> LocalizedTexts { get; set; }
    }
}
