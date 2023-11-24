using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CORE.Utilities.Security.Encryption
{
    public class SigningCredetialsHelper
    {
        public static SigningCredentials CreateSigningCredentials(SecurityKey security)//Hangi anahtarı kullanacaksın
        {
            return new SigningCredentials(security, SecurityAlgorithms.HmacSha512Signature);//Hangi Algoritmayı kullanacaksın
            //JWT yoneticeksin güvenlik anahtarın security'dir sifreleme algoritman ise HmacSha12Signature'dir...


        }
    }
}
