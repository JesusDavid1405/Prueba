using Entity.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Utilities.JWT
{
    public class JWT
    {
        private readonly IConfiguration _configuration;

        public JWT(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<string> GenerateJWT(Estudiante estudiante)
        {
            var Claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, $"{estudiante.Nombre} + {estudiante.Apellido}"),
                new Claim("numeroDocumento", estudiante.NumeroDocumento),
                new Claim(ClaimTypes.MobilePhone, estudiante.NumeroDocumento),
            };

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:key"]!));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            int expirationMinutes = int.Parse(_configuration["Jwt:Expirate"]!);

            var JwtConfig = new JwtSecurityToken(
                claims: Claims,
                expires: DateTime.UtcNow.AddMinutes(expirationMinutes),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(JwtConfig);
        }
    }
}
