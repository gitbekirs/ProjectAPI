using ProjectApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApi.Domain.Entities
{
    public class Article:BaseEntity
    {
        public string Header { get; set; }
        public string Spot { get; set; }
        public string Body { get; set; }
        public User User { get; set; }
    }
}
