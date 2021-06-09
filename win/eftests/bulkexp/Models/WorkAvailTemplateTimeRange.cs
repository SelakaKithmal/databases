using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class WorkAvailTemplateTimeRange
    {
        public int WorkAvailTemplateTimeRangeId { get; set; }
        public int FkWorkAvailTemplateDayId { get; set; }
        public int? FkLocationId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int? ChangedBy { get; set; }
        public DateTime? ChangedDate { get; set; }

        public virtual User ChangedByNavigation { get; set; }
        public virtual Location FkLocation { get; set; }
        public virtual WorkAvailTemplateDay FkWorkAvailTemplateDay { get; set; }
    }
}
