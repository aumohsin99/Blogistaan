using Blogistaan.Models;
using Blogistaan.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blogistaan.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        public IActionResult Dashboard()
        {
            var adminrepo = new AdminRepo();
            var listofWriters = adminrepo.FetchAllWriters();

            return View(listofWriters);
        }

        [HttpGet]
        public IActionResult AddWriter()
        {


            return View();
        }

        [HttpPost]
        public IActionResult AddWriter(string username, string password)
        {
            // Create a new instance of the Writer model and set the username and password
            var writer = new Writer
            {
                Username = username,
                Password = password
            };

            var adminrepo = new AdminRepo();
            if (adminrepo.AddWriter(writer))
            {
                return RedirectToAction("Dashboard", "Admin");

            }
            else
                return View();

            //adminrepo.AddWriter(writer);

            // Add the new writer to the database context
            //dbContext.Writers.Add(writer);
            //adminrepo.SaveChanges();






            //return View(listofWriters);

            // Optionally, you can redirect to a different action or view after adding the writer
            return RedirectToAction("Dashboard", "Admin");
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
