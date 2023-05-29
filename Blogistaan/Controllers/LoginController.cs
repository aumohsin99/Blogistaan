using Blogistaan.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Blogistaan.Controllers
{
    public class LoginController : Controller
    {


        [HttpGet]
        public IActionResult WriterLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult WriterLogin(Writer writerobj)
        {
            // Handle login logic here
            if (writerobj.Username == "w1" && writerobj.Password=="1") 
            {
                return RedirectToAction("Dashboard", "Writer");

                //return View("Writer/Dashboard");

            }
            else
            {
                return View();

            }


            //return View();
        }

        [HttpGet]
        public IActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminLogin(Admin adminobj)
        {

            if (adminobj.Username == "a1" && adminobj.Password == "1")
            {
                return RedirectToAction("Dashboard", "Admin");
            }
            else
            {
                return View();

            }
        }

       

    }
}
