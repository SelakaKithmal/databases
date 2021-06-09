using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class UserWorkLocation
    {
        public int UserWorkLocationId { get; set; }
        public int FkUserId { get; set; }
        public int FkLocationId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual Location FkLocation { get; set; }
        public virtual User FkUser { get; set; }
    }
}
