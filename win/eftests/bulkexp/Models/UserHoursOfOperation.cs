using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class UserHoursOfOperation
    {
        public int UserHoursOfOperationId { get; set; }
        public int FkUserId { get; set; }
        public bool? IsAvailable { get; set; }
        public short WeekNumber { get; set; }
        public short DayNumber { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int? FkWorkLocationId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ChangedBy { get; set; }
        public DateTime? ChangedDate { get; set; }

        public virtual User ChangedByNavigation { get; set; }
        public virtual User CreatedByNavigation { get; set; }
        public virtual User FkUser { get; set; }
    }
}
