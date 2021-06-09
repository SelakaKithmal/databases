using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class WorkExceptionType
    {
        public int WorkExceptionTypeId { get; set; }
        public string WorkExceptionTypeName { get; set; }
        public string WorkExceptionCode { get; set; }
        public string ColorCode { get; set; }
        public string LocalizedKey { get; set; }
    }
}
