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
        public string Name { get; set; }
        public string Email { get; set; }
        public ICollection<Article> Articles { get; set; }
        public ICollection<ContentUserPermissions> ArticleUserPermissions { get; set; }
    }
}
