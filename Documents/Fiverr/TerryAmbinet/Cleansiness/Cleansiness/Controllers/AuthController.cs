using AutoMapper;
using Cleansiness.Helpers;
using Cleansiness.Shared.DTO;
using Cleansiness.Shared.Interfaces;
using Cleansiness.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Cleansiness.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthRepository _repo;
        public IConfiguration _config;
        private readonly IMapper _mapper;
        private readonly ICommonRepository _common;

        public AuthController(IAuthRepository repo, IConfiguration configuration, IMapper mapper,
            ICommonRepository common)
        {
            _mapper = mapper;
            _common = common;
            _config = configuration;
            _repo = repo;
        }
        public IActionResult Login()
        {
            ViewBag.Users = _common.GetAppUsers();
            return View(new UserForLoginDto { IsTriedForLogin = false });
        }

        [HttpPost]
        public IActionResult Login(UserForLoginDto pUserForLoginDto)
        {
            ViewBag.Users = _common.GetAppUsers();
            AppUser vAppUser = _repo.Login(pUserForLoginDto.UserName, pUserForLoginDto.Password);
            if (vAppUser != null)
            {
                if (vAppUser.UserStatus)
                {
                    string vAppUserContent = JsonConvert.SerializeObject(vAppUser, Formatting.Indented,
                    new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects });
                    HttpContext.Session.SetString(SessionHelper.UserId, vAppUser.UserId.ToString());
                    HttpContext.Session.SetString(SessionHelper.UserEmail, vAppUser.Email.ToString());
                    HttpContext.Session.SetString(SessionHelper.AppUser, vAppUserContent);
                    HttpContext.Session.SetString(SessionHelper.UserType, vAppUser.UserType.ToString());
                    HttpContext.Session.SetString(SessionHelper.UserName, vAppUser.UserName);
                    _common.LogUserActivity(vAppUser, 1);
                    return RedirectToAction("Dashboard", "Admin");
                }
                else
                {
                    return View(new UserForLoginDto { IsTriedForLogin = true });
                }
            }
            else
            {
                return View(new UserForLoginDto { IsTriedForLogin = true });
            }
        }

        [HttpGet]
        public IActionResult Logout()
        {
            if (!SessionHelper.IsLoggedIn(HttpContext))
                return RedirectToAction("login", "auth");
            var vAppUser = JsonConvert.DeserializeObject<AppUser>(HttpContext.Session.GetString(SessionHelper.AppUser));
            _common.LogUserActivity(vAppUser, 2);
            SessionHelper.DestroySession(HttpContext);
            return RedirectToAction("login", "auth");
        }
    }
}
