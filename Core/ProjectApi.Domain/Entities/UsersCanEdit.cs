using ProjectApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApi.Domain.Entities
{
    public class UsersCanEdit:BaseEntityDynamicTables
    {
        public Article Article { get; set; }
        public User User { get; set; }
    }
}
