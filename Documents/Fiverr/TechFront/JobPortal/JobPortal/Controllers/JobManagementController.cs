using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JobPortal.Controllers
{
    public class JobManagementController : Controller
    {
        [Authorize(Roles = "Employer, Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
