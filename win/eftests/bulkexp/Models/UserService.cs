using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class UserService
    {
        public int FkUserId { get; set; }
        public int FkServiceId { get; set; }
        public byte Proficiency { get; set; }
        public bool OptIn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ChangedBy { get; set; }
        public DateTime? ChangedDate { get; set; }

        public virtual User ChangedByNavigation { get; set; }
        public virtual User CreatedByNavigation { get; set; }
        public virtual Service FkService { get; set; }
        public virtual User FkUser { get; set; }
    }
}
