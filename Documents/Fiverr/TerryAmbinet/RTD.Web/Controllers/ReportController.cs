﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RTD.Web.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Report()
        {
            return View();
        }
    }
}
