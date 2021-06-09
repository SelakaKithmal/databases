using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class UserSignIn
    {
        public UserSignIn()
        {
            LobbyInteractions = new HashSet<LobbyInteraction>();
            UserSignInHistories = new HashSet<UserSignInHistory>();
        }

        public long UserSignInSessionId { get; set; }
        public int FkLocationId { get; set; }
        public int FkLobbyId { get; set; }
        public int FkUserId { get; set; }
        public DateTime SignInTime { get; set; }
        public int FkSignInStatusId { get; set; }
        public DateTime CurrentStatusChangeTime { get; set; }
        public string StatusReason { get; set; }
        public DateTime? SignOutTime { get; set; }

        public virtual Lobby FkLobby { get; set; }
        public virtual Location FkLocation { get; set; }
        public virtual UserSignInStatus FkSignInStatus { get; set; }
        public virtual User FkUser { get; set; }
        public virtual ICollection<LobbyInteraction> LobbyInteractions { get; set; }
        public virtual ICollection<UserSignInHistory> UserSignInHistories { get; set; }
    }
}
