using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Project.CORE.Extension
{
    public static class ClaimExtensions
    {
        /*
         * Buradaki this keyword'u git benim AddEmail Metodumu ICollection<Claim>' class'ına ekle demektir.
         
         */

        public static void AddEmail(this ICollection<Claim> claims, string email)
        {
            claims.Add(new Claim(JwtRegisteredClaimNames.Email, email));
        }

        public static void AddName(this ICollection<Claim> claims, string name)
        {
            claims.Add(new Claim(ClaimTypes.Name, name));
        }

        public static void AddNameIdentifier(this ICollection<Claim> claims, string nameIdentifier)
        {
            claims.Add(new Claim(ClaimTypes.NameIdentifier, nameIdentifier));
        }

        public static void AddRoles(this ICollection<Claim> claims, string[] roles)//Bana gonderilen rolleri listeye cevir herbirini tek tek dolaş her bir rolü claim et
        {
            roles.ToList().ForEach(role => claims.Add(new Claim(ClaimTypes.Role, role)));
        }
    }
}
