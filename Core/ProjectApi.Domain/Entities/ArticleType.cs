using ProjectApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApi.Domain.Entities
{
    public class ArticleType:BaseEntityParametricTables
    {
        public string ArticleTypeName { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
