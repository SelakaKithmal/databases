using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class Checklist
    {
        public int ChecklistId { get; set; }
        public int FkServiceId { get; set; }
        public double? SortValue { get; set; }
        public string ChecklistItem { get; set; }
        public string LinkName { get; set; }
        public string Link { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ChangedBy { get; set; }
        public DateTime? ChangedDate { get; set; }

        public virtual User ChangedByNavigation { get; set; }
        public virtual User CreatedByNavigation { get; set; }
        public virtual Service FkService { get; set; }
    }
}
