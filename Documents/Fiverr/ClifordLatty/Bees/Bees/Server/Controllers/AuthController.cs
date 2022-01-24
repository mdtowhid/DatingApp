using Bees.Shared.DTO;
using Bees.Shared.Models;
using Bees.Shared.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Bees.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        private readonly IWebHostEnvironment _env;
        private readonly IConfiguration _config;
        private readonly IConfigurationSection _jwtSettings;

        public AuthController(IAuthRepository repo, IWebHostEnvironment env, IConfiguration config)
        {
            _repo = repo;
            _env = env;
            _config = config;
            _jwtSettings = _config.GetSection("JwtSettings");
        }


        [HttpGet("test")]
        public async Task<ActionResult<User>> Test()
        {
            string root = _env.WebRootPath;
            try
            {
                string text = System.IO.File.ReadAllText(_env.ContentRootPath + "/wwwroot/EmailTemplate.html");
                return Ok(text);
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        [HttpPost("register")]
        public async Task<ActionResult<User>> Register(User user)
        {
            if (user != null)
            {
                user = await _repo.Register(user);
            }
            return Ok(user);
        }



        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserForLoginDto pUserForLoginDto)
        {
            var vAuthResponseDto = await _repo.Login(pUserForLoginDto);
            if (vAuthResponseDto.IsAuthSuccessful)
            {
                var signingCredentials = GetSigningCredentials();
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, vAuthResponseDto.User.Id),
                    new Claim(ClaimTypes.Name, vAuthResponseDto.User.UserName),
                    new Claim(ClaimTypes.Email, vAuthResponseDto.User.Email),
                    new Claim(ClaimTypes.Role, vAuthResponseDto.User.UserType.ToString()),
                };
                var tokenOptions = GenerateTokenOptions(signingCredentials, claims);
                var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                vAuthResponseDto.Token = token;
                return Ok(vAuthResponseDto);
            }
            vAuthResponseDto.ErrorMessage = "Invalid login!";
            return Ok(vAuthResponseDto);
        }



        [HttpPost("ConfirmEmail")]
        public async Task<ActionResult<User>> ConfirmEmail([FromBody] string id)
        {
            var user = await _repo.ConfirmEmail(id);
            return Ok(user);
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
    }
}
