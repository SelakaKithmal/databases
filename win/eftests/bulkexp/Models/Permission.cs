using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class Permission
    {
        public Permission()
        {
            RolePermissions = new HashSet<RolePermission>();
        }

        public int PermissionId { get; set; }
        public string PermissionName { get; set; }
        public string PermissionDisplayName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int? ChangedBy { get; set; }
        public DateTime? ChangedDateTime { get; set; }

        public virtual User ChangedByNavigation { get; set; }
        public virtual User CreatedByNavigation { get; set; }
        public virtual ICollection<RolePermission> RolePermissions { get; set; }
    }
}
