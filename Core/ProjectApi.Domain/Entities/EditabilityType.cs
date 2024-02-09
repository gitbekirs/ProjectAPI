using ProjectApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApi.Domain.Entities
{
    public class EditabilityType:BaseEntityParametricTables
    {
        public string EditabilityTypeName { get; set; }//public, private or restricted(only selected users) 
    }
}
