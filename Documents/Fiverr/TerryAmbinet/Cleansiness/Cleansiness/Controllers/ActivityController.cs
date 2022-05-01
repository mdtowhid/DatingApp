using Microsoft.AspNetCore.Mvc;

namespace Cleansiness.Controllers
{
    public class ActivityController : Controller
    {
        public IActionResult AuditActivity()
        {
            return View();
        }
    }
}
