using ProjectApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApi.Domain.Entities
{
    public class ExpandabilityType:BaseEntityParametricTables
    {
        public string ExpandabilityTypeName { get; set; }//public, private or restricted(only selected users) 
    }
}
