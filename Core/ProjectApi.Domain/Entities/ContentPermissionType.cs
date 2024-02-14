using ProjectApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApi.Domain.Entities
{
    public class ContentPermissionType:BaseEntityParametricTables
    {
        public string ContentPermissionTypeName { get; set; }//viewing,editing,expanding
        public ICollection<Content> Contents { get; set; }
        public ICollection<ContentUserPermissions> ContentUserPermissions { get; set; }
    }
}
