using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CORE.Utilities.JWTToken
{
   public class AccessToken
    {
        public string Token { get; set; } //Anlamsız karakterlerden olusan bir string degeridir Jshon Web Token degerimizin kendisi.
        public DateTime Expiration { get; set; }//Bitiş süresi,zamanı
    }
}
