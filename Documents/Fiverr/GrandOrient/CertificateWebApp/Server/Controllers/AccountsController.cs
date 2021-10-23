using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using CertificateWebApp.Shared.Interfaces;
using CertificateWebApp.Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace CertificateWebApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IUserRepository _repo;
        private readonly IConfiguration _config;
        private readonly IConfigurationSection _jwtSettings;

        public AccountsController(IUserRepository repo, IConfiguration config)
        {
            _repo = repo;
            _config = config;
            _jwtSettings = _config.GetSection("JwtSettings");
        }

        private SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.UTF8.GetBytes(_jwtSettings["securityKey"]);
            var secret = new SymmetricSecurityKey(key);

            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }
        private List<Claim> GetClaims(IdentityUser user)
        {
            var claims = new List<Claim>
            {
                new(ClaimTypes.Name, user.Email)
            };

            return claims;
        }
        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var tokenOptions = new JwtSecurityToken(
                issuer: _jwtSettings["validIssuer"],
                audience: _jwtSettings["validAudience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(_jwtSettings["expiryInMinutes"])),
                signingCredentials: signingCredentials);

            return tokenOptions;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(User user)
        {
            var checkedUser = await _repo.Login(user);
            if (checkedUser == null)
            {
                return Unauthorized(new AuthResponseDto { ErrorMessage = "Invalid Authantication." });
            }

            var signingCredentials = GetSigningCredentials();
            var claims = new List<Claim>
            {
                new(ClaimTypes.NameIdentifier, checkedUser.Id.ToString()),
                new(ClaimTypes.Name, checkedUser.Name),
                new(ClaimTypes.Email, checkedUser.Email),
                new(ClaimTypes.Role, checkedUser.Role)
            };
            var tokenOptions = GenerateTokenOptions(signingCredentials, claims);
            var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
            return Ok(new AuthResponseDto { IsAuthSuccessful = true, Token = token });
        }
    }
}
