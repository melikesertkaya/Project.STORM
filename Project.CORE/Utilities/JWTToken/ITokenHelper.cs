using Project.CORE.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CORE.Utilities.JWTToken
{
    public interface ITokenHelper
    {/// <summary>
     /// Token Uretecek Methodumuz.
     /// </summary>
     /// <param name="user">User için bir Token olustur</param>
     /// <param name="operationClaims"> Token içerisine istedigimiz yetkileri koymak için</param>
     /// <returns></returns>
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
