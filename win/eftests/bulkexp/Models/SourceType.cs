using System;
using System.Collections.Generic;

#nullable disable

namespace bulkexp.Models
{
    public partial class SourceType
    {
        public SourceType()
        {
            Appointments = new HashSet<Appointment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
