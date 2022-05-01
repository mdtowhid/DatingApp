﻿using AutoMapper;
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
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserForLoginDto pUserForLoginDto)
        {
            AppUser vAppUser = _repo.Login(pUserForLoginDto.Email, pUserForLoginDto.Password);
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
                    _common.LogUserActivity(vAppUser, 1);
                    return RedirectToAction("Dashboard", "Admin");
                }
                else
                {
                    return View(new AppUser { IsLoggedIn = false });
                }
            }
            else
            {
                return View(new AppUser { IsLoggedIn = false });
            }
        }
        public IActionResult Logout()
        {
            return RedirectToAction("Login");
        }
    }
}