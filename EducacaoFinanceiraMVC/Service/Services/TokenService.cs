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
		public string GenerateToken(User user, string Secret)
		{
            var handler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Secret);

            var Role = string.IsNullOrEmpty(user.Role) ? "" : user.Role;
            var token = new SecurityTokenDescriptor()
            {    
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Role, Role)
                }),
                Expires = DateTime.Now.AddHours(12),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            return handler.WriteToken(
                handler.CreateToken(token)
                );
        }
	}
}

