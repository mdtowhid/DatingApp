using Microsoft.AspNetCore.Mvc;
using RTD.Web.Models;
using RTD.Web.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTD.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAuthRepository _authRepo;

        public AuthController(IAuthRepository authRepo)
        {
            _authRepo = authRepo;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(AppUser pAppUser)
        {
            AppUser vAppUser = _authRepo.LogIn(pAppUser);

            if (vAppUser != null)
            {
                return RedirectToAction("Dashboard", "RtdAdmin");
            }
            else
            {
                return View(new AppUser { IsLoggedIn=false});
            }
        }
    }
}
