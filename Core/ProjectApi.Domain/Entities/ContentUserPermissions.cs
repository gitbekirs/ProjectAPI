using ProjectApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApi.Domain.Entities
{
    //sadece content Type restricted olan content'lar için kayıt girilir.
    public class ContentUserPermissions:BaseEntityDynamicTables
    {
        public User User { get; set; }
        public Content Content { get; set; }
        public ContentPermissionType PermissionType { get; set; }
        public DateTime? ValidityDate { get; set; }
    }
}
