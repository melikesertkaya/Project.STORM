using Project.CORE.DAL.Abstarct;
using Project.CORE.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Abstract
{
   public interface IUserDataAccess:IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
