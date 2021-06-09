using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class ResourceExceptionType
    {
        public int ResourceExceptionTypeId { get; set; }
        public string ResourceExceptionTypeName { get; set; }
        public string ResourceExceptionCode { get; set; }
        public string ColorCode { get; set; }
        public string LocalizedKey { get; set; }
    }
}
