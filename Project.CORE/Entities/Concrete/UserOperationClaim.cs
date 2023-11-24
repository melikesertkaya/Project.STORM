using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CORE.Entities.Concrete
{
   public class UserOperationClaim:IEntity
    {
        public Guid Id { get; set; }//Bire Çok ilişki
        public Guid UserId { get; set; }
        public Guid OperationClaimId { get; set; }

        //Relational Properties 
        public virtual User Users { get; set; }
        public virtual  OperationClaim OperationClaim { get; set; }

    }
}
