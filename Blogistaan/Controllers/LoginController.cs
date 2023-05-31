using Blogistaan.Models;
using Blogistaan.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Blogistaan.Controllers
{
    public class LoginController : Controller
    {
        //WriterRepo writerrepo;

        //public LoginController(ContextClass dbContext)
        //{
        //    writerrepo = new WriterRepo(dbContext);
        //}


        [HttpGet]
        public IActionResult WriterLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult WriterLogin(Writer writerobj)
        {

            // Handle login logic here
            //if (writerobj.Username == "w1" && writerobj.Password == "1")
            var writerrepo = new WriterRepo();
            if (writerrepo.ValidateWriterLogin(writerobj.Username, writerobj.Password))
            {
                return RedirectToAction("Dashboard", "Writer");

            }
            else
            {
                return View();

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
            if (adminrepo.ValidateAdminLogin(adminobj.Username, adminobj.Password))
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
