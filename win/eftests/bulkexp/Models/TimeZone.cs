using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class TimeZone
    {
        public TimeZone()
        {
            Locations = new HashSet<Location>();
            Users = new HashSet<User>();
        }

        public int TimeZoneId { get; set; }
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public string StandardName { get; set; }
        public string DaylightName { get; set; }
        public bool? SupportsDaylightSavingTime { get; set; }
        public decimal? UtcoffsetInMinutes { get; set; }

        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
