using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class LocationService
    {
        public int FkLocationId { get; set; }
        public int FkServiceId { get; set; }
        public double? SortValue { get; set; }

        public virtual Location FkLocation { get; set; }
        public virtual Service FkService { get; set; }
    }
}
