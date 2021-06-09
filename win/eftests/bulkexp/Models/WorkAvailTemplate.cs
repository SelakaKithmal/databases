using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class WorkAvailTemplate
    {
        public WorkAvailTemplate()
        {
            WorkAvailTemplateDays = new HashSet<WorkAvailTemplateDay>();
        }

        public int WorkAvailTemplateId { get; set; }
        public int? FkLocationId { get; set; }
        public int? FkUserId { get; set; }
        public byte NumberOfRotations { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ChangedBy { get; set; }
        public DateTime? ChangedDate { get; set; }
        public byte ActiveStatus { get; set; }

        public virtual User ChangedByNavigation { get; set; }
        public virtual User CreatedByNavigation { get; set; }
        public virtual Location FkLocation { get; set; }
        public virtual User FkUser { get; set; }
        public virtual ICollection<WorkAvailTemplateDay> WorkAvailTemplateDays { get; set; }
    }
}
