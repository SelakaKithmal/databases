using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class AuditAction
    {
        public AuditAction()
        {
            AuditLogs = new HashSet<AuditLog>();
        }

        public int AuditActionId { get; set; }
        public string AuditActionName { get; set; }

        public virtual ICollection<AuditLog> AuditLogs { get; set; }
    }
}
