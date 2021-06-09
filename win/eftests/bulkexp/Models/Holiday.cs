using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class Holiday
    {
        public Holiday()
        {
            InverseFkHolidayParent = new HashSet<Holiday>();
        }

        public int HolidayId { get; set; }
        public int? FkHolidayParentId { get; set; }
        public int FkLocationId { get; set; }
        public string HolidayName { get; set; }
        public DateTime Date { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool? IsAllDay { get; set; }
        public bool OptIn { get; set; }
        public bool IsBlackout { get; set; }
        public byte ActiveStatus { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ChangedBy { get; set; }
        public DateTime? ChangedDate { get; set; }

        public virtual User ChangedByNavigation { get; set; }
        public virtual User CreatedByNavigation { get; set; }
        public virtual Holiday FkHolidayParent { get; set; }
        public virtual Location FkLocation { get; set; }
        public virtual ICollection<Holiday> InverseFkHolidayParent { get; set; }
    }
}
