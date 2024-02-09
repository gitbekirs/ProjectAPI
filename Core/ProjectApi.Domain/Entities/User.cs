using ProjectApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApi.Domain.Entities
{
    public class User:BaseEntityDynamicTables
    {
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public ICollection<Article> Articles { get; set; }
        public ICollection<UsersCanEdit> UsersCanEdits { get; set; }
        public ICollection<UsersCanExpand> UsersCanExpands { get; set; }
        public ICollection<UsersCanVisible> UsersCanVisibles { get; set; }
    }
}
