using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class ResourceType
    {
        public int ResourceTypeId { get; set; }
        public string ResourceTypeName { get; set; }
        public string ResourceTypeDescription { get; set; }
        public string LocalizedKey { get; set; }
    }
}
