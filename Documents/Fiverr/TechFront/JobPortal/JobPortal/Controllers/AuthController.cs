using AutoMapper;
using JobPortal.Shared.DTO;
using JobPortal.Shared.Enums;
using JobPortal.Shared.Models;
using JobPortal.Shared.Repositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace JobPortal.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthRepository _repo;
        public IConfiguration _config;
        private readonly IMapper _mapper;
        public AuthController(IAuthRepository repo, IConfiguration configuration, IMapper mapper)
        {
            _mapper = mapper;
            _config = configuration;
            _repo = repo;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> ConfirmEmail(int pId)
        {
            if (ModelState.IsValid)
            {
                ViewBag.AuthResponseDto = await _repo.ConfirmEmail(pId);
                return View(pId);
            }
            return View(null);
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserForCreationDto pUserForCreationDto)
        {
            if (ModelState.IsValid)
            {
                ViewBag.AuthResponseDto = await _repo.Register(pUserForCreationDto);
                return View(new UserForCreationDto());
            }
            return View(null);
        }
        
        

        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(string pEmail)
        {
            ViewBag.AuthResponseDto = new ApiResponseDto<User>
            {
                Message = $"Please enter valid email address",
                ResponseType = ResponseType.Failed,
            };
            if (pEmail != null)
            {
                if(IsValidEmail(pEmail))
                {
                    var vApiResponseDto = await _repo.ForgotPassword(pEmail);
                    ViewBag.AuthResponseDto = vApiResponseDto;
                    return View();
                }
            }
            return View();
        }

        bool IsValidEmail(string pEmail)
        {
            var trimmedEmail = pEmail.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(pEmail);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        [HttpGet]
        public async Task<IActionResult> RecoverAccount(int pId)
        {
            var vApiResponseDto = await _repo.GetUserById(pId);
            RecoverAccountDto vRecoverAccountDto = new();
            if (vApiResponseDto != null)
            {
                vRecoverAccountDto.Id = vApiResponseDto.Result.Id;
            }
            return View(vRecoverAccountDto);
        }

        [HttpPost]
        public async Task<IActionResult> RecoverAccount(RecoverAccountDto pRecoverAccountDto)
        {
            ViewBag.AuthResponseDto = await _repo.RecoverAccount(pRecoverAccountDto);
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserForLoginDto userForLoginDto)
        {
            var vAuthResponseDto = await _repo.Login(userForLoginDto);
            ViewBag.AuthResponseDto = vAuthResponseDto;
            if (vAuthResponseDto == null) return View();
            
            var claims = new[]{
                new Claim(ClaimTypes.NameIdentifier, vAuthResponseDto.User.Id.ToString()),
                new Claim(ClaimTypes.Email, vAuthResponseDto.User.Email),
                new Claim(ClaimTypes.Role, GetUserRole(vAuthResponseDto.User)),
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var vClaimsPrincipal = new ClaimsPrincipal(new[] { claimsIdentity });

            await HttpContext.SignInAsync(vClaimsPrincipal);

            if(vAuthResponseDto.IsAuthSuccessful)
                return RedirectToAction("Index", "JobManagement");
            else return View();
        }


        private string GetUserRole(User pUser)
        {
            string vOut = string.Empty;

            if(pUser.UserTypeId == 1)
                vOut = "Admin";
            else if (pUser.UserTypeId == 2)
                vOut = "Employer";
            else if (pUser.UserTypeId == 1)
                vOut = "Candidate";
            return vOut;
        }
    }
}
