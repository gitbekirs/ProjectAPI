using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApi.Domain.Entities.Common
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        //public Guid CreatedUserId { get; set; }
        //public DateTime? ModifiedDate { get; set; }
        //public Guid ModifiedUserId { get; set; }
        //public DateTime? DeletedDate { get; set; }
        //public Guid DeletedUserId { get; set; }
        //public bool IsActive { get; set; }
        //public bool IsDeleted { get; set; }
    }
}
