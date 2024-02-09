using ProjectApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApi.Domain.Entities
{
    public class ArticlePermissionType:BaseEntityParametricTables
    {
        public string ArticlePermissionTypeName { get; set; }//viewing,editing,expanding
        public ICollection<ArticleUserPermissions> ArticleUserPermissions { get; set; }
    }
}
