using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class LocationHoursOfOperation
    {
        public int LocationHoursOfOperationId { get; set; }
        public int FkLocationId { get; set; }
        public short DayNumber { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public bool IsClosed { get; set; }
        public bool? OnlineCheckInEnabledForDay { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ChangedBy { get; set; }
        public DateTime? ChangedDate { get; set; }

        public virtual User ChangedByNavigation { get; set; }
        public virtual User CreatedByNavigation { get; set; }
        public virtual Location FkLocation { get; set; }
    }
}
