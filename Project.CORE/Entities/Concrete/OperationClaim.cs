using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CORE.Entities.Concrete
{
    public class OperationClaim:IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual List<OperationClaim> OperationClaims { get; set; }

    }
}
