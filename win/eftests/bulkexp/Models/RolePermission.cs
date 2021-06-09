using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class RolePermission
    {
        public int RolePermissionId { get; set; }
        public int FkRoleId { get; set; }
        public int FkPermissionId { get; set; }

        public virtual Permission FkPermission { get; set; }
        public virtual Role FkRole { get; set; }
    }
}
