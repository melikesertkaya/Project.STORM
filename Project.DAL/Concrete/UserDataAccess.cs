using Project.CORE.DAL.Concrete;
using Project.CORE.Entities.Concrete;
using Project.DAL.Abstract;
using Project.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Concrete
{
    public class UserDataAccess : EntityRepository<User, MyContext>, IUserDataAccess
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new MyContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}
