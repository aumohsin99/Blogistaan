using Microsoft.AspNetCore.Mvc;

namespace Blogistaan.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
