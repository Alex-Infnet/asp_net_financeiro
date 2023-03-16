using System;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Domain.Entities;

namespace Service.Services
{
	public class TokenService
	{
        private string Secret = "HEREIS$MY$SECRET";
		public string GenerateToken(User user)
		{
            var handler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Secret);

            var token = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Email, user.Email)
                }),
                Expires = DateTime.Now.AddHours(12)
            };

            return handler.WriteToken(
                handler.CreateToken(token)
                );
        }
	}
}

