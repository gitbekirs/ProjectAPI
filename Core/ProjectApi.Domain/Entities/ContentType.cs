using ProjectApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApi.Domain.Entities
{
    public class ContentType:BaseEntityParametricTables
    {
        public string ContentTypeName { get; set; }//makale,şiir,şarkı sözü,senaryo vs..
        public ICollection<Content> Contents { get; set; }
    }
}
