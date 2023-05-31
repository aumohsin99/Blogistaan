using Blogistaan.Models;
using Blogistaan.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Blogistaan.Controllers
{
    public class LoginController : Controller
    {
        WriterRepo writerrepo;

        public LoginController(ContextClass dbContext)
        {
            writerrepo = new WriterRepo(dbContext);
        }


        [HttpGet]
        public IActionResult WriterLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult WriterLogin(Writer writerobj)
        {

            // Handle login logic here

            if (writerrepo.ValidateLogin(writerobj.Username, writerobj.Password))
            {
                return RedirectToAction("Dashboard", "Writer");

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
