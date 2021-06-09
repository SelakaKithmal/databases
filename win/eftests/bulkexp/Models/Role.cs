using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class Role
    {
        public Role()
        {
            RolePermissions = new HashSet<RolePermission>();
            UserRoles = new HashSet<UserRole>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public int Level { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int? ChangedBy { get; set; }
        public DateTime? ChangedDateTime { get; set; }

        public virtual User ChangedByNavigation { get; set; }
        public virtual User CreatedByNavigation { get; set; }
        public virtual ICollection<RolePermission> RolePermissions { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
