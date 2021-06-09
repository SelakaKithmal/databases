using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class Language
    {
        public Language()
        {
            LobbyEntries = new HashSet<LobbyEntry>();
            LocalizedTexts = new HashSet<LocalizedText>();
            Users = new HashSet<User>();
        }

        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
        public string LanguageShortName { get; set; }
        public string LocalizedKey { get; set; }

        public virtual ICollection<LobbyEntry> LobbyEntries { get; set; }
        public virtual ICollection<LocalizedText> LocalizedTexts { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
