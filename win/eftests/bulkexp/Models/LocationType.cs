using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class LocationType
    {
        public LocationType()
        {
            Locations = new HashSet<Location>();
        }

        public int LocationTypeId { get; set; }
        public string LocationTypeName { get; set; }
        public string LocationTypeDisplayName { get; set; }
        public string LocalizedKey { get; set; }

        public virtual ICollection<Location> Locations { get; set; }
    }
}
