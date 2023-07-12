using Blogistaan.Models;
using Blogistaan.Repository;
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

            // Your login validation logic

            //if (loginSuccess)
            //{
            //    // Successful login logic
            //    return RedirectToAction("Index", "Home");
            //}
           

            var writerrepo = new WriterRepo();
            int id = writerrepo.ValidateWriterLogin(writerobj.Username, writerobj.Password);
            if (id!=0)
            {
                HttpContext.Response.Cookies.Append("WriterId", id.ToString());

                return RedirectToAction("Dashboard", "Writer");

            }

            else
            {
                ViewBag.InvalidCredentials = true;
                //ModelState.AddModelError("", "Invalid credentials. Please try again.");
                return View();
                //return View();

            }


        }

        [HttpGet]
        public IActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminLogin(Admin adminobj)
        {

            var adminrepo = new AdminRepo();
            int id = adminrepo.ValidateAdminLogin(adminobj.Username, adminobj.Password);
            if (id!=0)
            {
                HttpContext.Response.Cookies.Append("AdminId", id.ToString());

                return RedirectToAction("Dashboard", "Admin");

            }
            

            else
            {
                ViewBag.InvalidCredentials = true;
                //ModelState.AddModelError("", "Invalid credentials. Please try again.");
                //return View(admin);
                return View();

            }

        }

       

    }
}
