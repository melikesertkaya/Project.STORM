using Project.CORE.Entities;
using Project.CORE.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Entities
{
   public abstract class BaseEntity:IEntity
    {
        public Guid Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public State   State { get; set; }
        public BaseEntity()
        {
            CreatedDate = DateTime.UtcNow;
            State = State.Inserted;
        }
    }
}
