using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class UserSignInHistory
    {
        public long UserSignInHistoryId { get; set; }
        public long FkUserSignInSessionId { get; set; }
        public int FkSignInStatusId { get; set; }
        public DateTime StatusChangeTime { get; set; }
        public string StatusReason { get; set; }

        public virtual UserSignInStatus FkSignInStatus { get; set; }
        public virtual UserSignIn FkUserSignInSession { get; set; }
    }
}
