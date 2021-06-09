using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class WorkAvailTemplateDay
    {
        public WorkAvailTemplateDay()
        {
            WorkAvailTemplateTimeRanges = new HashSet<WorkAvailTemplateTimeRange>();
        }

        public int WorkAvailTemplateDayId { get; set; }
        public int FkWorkAvailTemplateId { get; set; }
        public byte WeekNumber { get; set; }
        public byte DayNumber { get; set; }
        public int? ChangedBy { get; set; }
        public DateTime? ChangedDate { get; set; }

        public virtual User ChangedByNavigation { get; set; }
        public virtual WorkAvailTemplate FkWorkAvailTemplate { get; set; }
        public virtual ICollection<WorkAvailTemplateTimeRange> WorkAvailTemplateTimeRanges { get; set; }
    }
}
