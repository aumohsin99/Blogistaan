using Microsoft.AspNetCore.Mvc;

namespace Blogistaan.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
