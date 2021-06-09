using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class UserSignInStatus
    {
        public UserSignInStatus()
        {
            UserSignInHistories = new HashSet<UserSignInHistory>();
            UserSignIns = new HashSet<UserSignIn>();
        }

        public int StatusId { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<UserSignInHistory> UserSignInHistories { get; set; }
        public virtual ICollection<UserSignIn> UserSignIns { get; set; }
    }
}
