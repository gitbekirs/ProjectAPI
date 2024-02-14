using ProjectApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApi.Domain.Entities
{
    public class Content:BaseEntityDynamicTables
    {
        public ContentType ContentType { get; set; }//makale,şiir,şarkı sözü, senaryo vs..
        public ContentAccessType ContentAccessType { get; set; } //public, private or restricted(only selected users)
        public ICollection<ContentPermissionType> ContentPermissionTypes { get; set; }//viewing,editing,expanding    
    }
}
