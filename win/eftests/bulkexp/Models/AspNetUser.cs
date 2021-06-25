using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class AspNetUser
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
    }
}
