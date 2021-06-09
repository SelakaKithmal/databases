using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class AssistType
    {
        public AssistType()
        {
            LobbyInteractions = new HashSet<LobbyInteraction>();
        }

        public int AssistTypeId { get; set; }
        public string AssistTypeName { get; set; }

        public virtual ICollection<LobbyInteraction> LobbyInteractions { get; set; }
    }
}
