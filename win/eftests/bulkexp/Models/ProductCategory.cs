using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            Services = new HashSet<Service>();
        }

        public int ProductCategoryId { get; set; }
        public int? FkProductCategoryTypeId { get; set; }
        public string ProductCategoryName { get; set; }
        public string ProductCategoryDisplayName { get; set; }
        public Guid LocalizedRowId { get; set; }
        public string ProductCategoryCode { get; set; }
        public int DisplaySortPosition { get; set; }
        public string IconName { get; set; }
        public bool DontShowInWidget { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? ChangedBy { get; set; }
        public DateTime? ChangedDate { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}
