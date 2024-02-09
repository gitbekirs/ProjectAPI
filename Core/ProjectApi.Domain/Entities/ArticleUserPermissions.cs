using ProjectApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApi.Domain.Entities
{
    //sadece rArticle Type restricted olan article'lar için kayıt girilir.
    public class ArticleUserPermissions:BaseEntityDynamicTables
    {
        public User User { get; set; }
        public Article Article { get; set; }
        public ArticlePermissionType PermissionType { get; set; }
        public DateTime? ValidityDate { get; set; }
    }
}
