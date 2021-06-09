using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class EntityType
    {
        public EntityType()
        {
            AuditLogs = new HashSet<AuditLog>();
        }

        public int EntityTypeId { get; set; }
        public string EntityTypeName { get; set; }
        public bool? AuditEnabled { get; set; }

        public virtual ICollection<AuditLog> AuditLogs { get; set; }
    }
}
