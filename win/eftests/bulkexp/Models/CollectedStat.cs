using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class CollectedStat
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
        public DateTime CollectedDate { get; set; }
        public DateTime EventDate { get; set; }
        public int Hour { get; set; }
        public string Stat { get; set; }
        public int TotalCount { get; set; }
        public int OngoingCount { get; set; }
        public double TotalTime { get; set; }
        public string GroupbyField1 { get; set; }
        public string GroupbyField2 { get; set; }
    }
}
