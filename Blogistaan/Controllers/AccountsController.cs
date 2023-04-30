using Microsoft.AspNetCore.Mvc;

namespace Blogistaan.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult AdminLogin()
        {
            return View();
        }

       

    }
}
