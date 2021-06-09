using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class UserRole
    {
        public int FkUserId { get; set; }
        public int FkRoleId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual User CreatedByNavigation { get; set; }
        public virtual Role FkRole { get; set; }
        public virtual User FkUser { get; set; }
    }
}
