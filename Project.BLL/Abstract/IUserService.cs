using Project.CORE.Entities.Concrete;
using Project.CORE.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        Task<IResult> Add(User user);
        User GetByMail(string email);
    }
}
