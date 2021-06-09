using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class AuditLog
    {
        public long AuditId { get; set; }
        public int FkAuditActionId { get; set; }
        public int FkEntityTypeId { get; set; }
        public string EntityId { get; set; }
        public int? FkuserId { get; set; }
        public string AuditData { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual AuditAction FkAuditAction { get; set; }
        public virtual EntityType FkEntityType { get; set; }
        public virtual User Fkuser { get; set; }
    }
}
