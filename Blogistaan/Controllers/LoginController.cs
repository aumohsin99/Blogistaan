using Blogistaan.Models;
using Microsoft.AspNetCore.Mvc;

namespace Blogistaan.Controllers
{
    public class LoginController : Controller
    {

      

        public IActionResult WriterLogin()
        {
            return View();
        }

        public IActionResult AdminLogin()
        {
            return View();
        }

       

    }
}
