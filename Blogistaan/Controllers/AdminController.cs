using Microsoft.AspNetCore.Mvc;

namespace Blogistaan.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult AddWriter()
        {
            return View();
        }

        public IActionResult UpdateWriter()
        {
            return View();
        }

        public IActionResult DeleteWriter()
        {
            return View();
        }
    }
}
