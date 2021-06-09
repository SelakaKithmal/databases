using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class OngoingTimeStat
    {
        public int LocationId { get; set; }
        public string Entity { get; set; }
        public string EntityId { get; set; }
        public string Stat { get; set; }
        public DateTime AddedTime { get; set; }
        public DateTime EventTime { get; set; }
        public string GroupbyField1 { get; set; }
        public string GroupbyField2 { get; set; }
    }
}
