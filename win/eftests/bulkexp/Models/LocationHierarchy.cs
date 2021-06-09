using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class LocationHierarchy
    {
        public int LocationId { get; set; }
        public int? ParentLocationId { get; set; }
        public string Hierarchy { get; set; }

        public virtual Location Location { get; set; }
        public virtual Location ParentLocation { get; set; }
    }
}
