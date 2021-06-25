using bulkexp.Types;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bulkexp.Mappings
{
    class UserMap : ClassMap<UserDTO>
    {
        public UserMap()
        {
            Map(m => m.Email).Name("Email");
            Map(m => m.NormalizedUserName).Name("NormalizedUserName");
            Map(m => m.UserName).Name("UserName");

        }
    }
}
