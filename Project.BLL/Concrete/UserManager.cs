using Microsoft.Extensions.Logging;
using Project.BLL.Abstract;
using Project.CORE.Entities.Concrete;
using Project.CORE.Utilities.Results;
using Project.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDataAccess _userDal;
        private readonly ILogger<UserManager> _logger;

        public UserManager(IUserDataAccess userDal,
             ILogger<UserManager> logger)
        {
            _userDal = userDal;
            _logger = logger;
        }

        public List<OperationClaim> GetClaims(User user)
        {

            return _userDal.GetClaims(user);

        }

        public async Task<IResult> Add(User user)
        {
            await _userDal.CreateAsync(user);

            return new SuccessResult("User Created");
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(x => x.Email == email);
        }
    }
}
