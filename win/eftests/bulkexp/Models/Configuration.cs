using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class Configuration
    {
        public int ConfigurationId { get; set; }
        public string ConfigurationName { get; set; }
        public string ConfigurationValue { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
