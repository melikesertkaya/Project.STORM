using Microsoft.Extensions.Configuration;
using Project.CORE.Entities.Concrete;
using System;
using System.Collections.Generic;
using Project.CORE.Utilities.Security.Encryption;
using System.Linq;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Project.CORE.Extension;

namespace Project.CORE.Utilities.JWTToken
{
    public class JWTHelper : ITokenHelper
    {
        public IConfiguration Configuration { get; }
        private TokenOptions _tokenOptions;//token'ın degerleri.
        private DateTime _accessTokenExpiration;//accessToken ne zaman geçersizleşicek?
        public JWTHelper(IConfiguration configuration)
        {
            Configuration = configuration;
            _tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();//app configden degerleri okur.
        }
        public AccessToken CreateToken(User user, List<OperationClaim> operationClaims)//User ve claimleri vericek method
        {
            _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);//Token ne zaman Expiration olcak ? 
            var securityKey = SecurityHelper.CreateSecurityKey(_tokenOptions.SecurityKey);//SecurityKey'i daki key'i kullan
            var signingCredentials = SigningCredetialsHelper.CreateSigningCredentials(securityKey);//hangi altoritmayı kullanayım anahtarım ne? CreateSigninCredentials dan geliyor bu ikiside.
            var jwt = CreateJwtSecurityToken(_tokenOptions, user, signingCredentials, operationClaims);//Ilgılı User için ilgili credentials kullanarak bu user'a atanacak yetkiler için metod yazdık altta burada onu veriyoruz.
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
            var token = jwtSecurityTokenHandler.WriteToken(jwt);

            return new AccessToken
            {
                Token = token,
                Expiration = _accessTokenExpiration
            };
        }
        public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, User user,
          SigningCredentials signingCredentials, List<OperationClaim> operationClaims)
        {
            var jwt = new JwtSecurityToken(//Bilgileri olusturuyor.
                issuer: tokenOptions.Issuer,
                audience: tokenOptions.Audience,
                expires: _accessTokenExpiration,
                notBefore: DateTime.Now,
                claims: SetClaims(user, operationClaims),//Claimleri olusturmak icin SetClaims Metodu yazdık aşşagıda burada kullanıyoruz.
                signingCredentials: signingCredentials
            );
            return jwt;
        }
        private IEnumerable<Claim> SetClaims(User user, List<OperationClaim> operationClaims)//Claim olusturmak.
        {
            //Burada Extension metodlarımızı cagırıyoruz...
            var claims = new List<Claim>();
            claims.AddNameIdentifier(user.Id.ToString());
            claims.AddEmail(user.Email);
            claims.AddName($"{user.FirstName} {user.LastName}");
            claims.AddRoles(operationClaims.Select(c => c.Name).ToArray());

            return claims;
        }
    }
}
