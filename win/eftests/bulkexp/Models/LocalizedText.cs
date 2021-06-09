using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class LocalizedText
    {
        public int LocalizedTextId { get; set; }
        public int FkLanguageId { get; set; }
        public int FkLocalizedFieldId { get; set; }
        public Guid LocalizedRowId { get; set; }
        public string Text { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ChangedBy { get; set; }
        public DateTime? ChangedDate { get; set; }

        public virtual User ChangedByNavigation { get; set; }
        public virtual User CreatedByNavigation { get; set; }
        public virtual Language FkLanguage { get; set; }
        public virtual LocalizedField FkLocalizedField { get; set; }
    }
}
