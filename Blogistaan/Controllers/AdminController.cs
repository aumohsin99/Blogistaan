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
            if (HttpContext.Request.Cookies.TryGetValue("AdminId", out string AdminIdString))
            {
                if (int.TryParse(AdminIdString, out int AdminId))
                {
                    var adminrepo = new AdminRepo();
                    var listofWriters = adminrepo.FetchAllWriters();

                    return View(listofWriters);
                }
                else
                {
                    return View();
                }

            }
            else
            {
                return RedirectToAction("AdminLogin", "Login");
            }           
        }


        [HttpPost]
        public IActionResult Logout()
        {
            if (Request.Cookies.ContainsKey("AdminId"))
            {
                Response.Cookies.Delete("AdminId");
            }

            //return RedirectToAction("Index", "Home");

            return RedirectToAction("AdminLogin", "Login");
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
            //return RedirectToAction("Dashboard", "Admin");
        }



        [HttpPost]
        public IActionResult DeleteWriter(int id)
        {

            var adminrepo = new AdminRepo();
            if (adminrepo.DeleteWriter(id))
            {
                return RedirectToAction("Dashboard", "Admin");

            }
            //writerrepo.DeleteBlog(id);

            return View();

        }
        public IActionResult UpdateWriter(int id)
        {
            var adminrepo = new AdminRepo();
            var writer = adminrepo.FetchWriterbyID(id);


            //var blog = dbContext.Blogs.FirstOrDefault(b => b.Id == id);
            if (writer == null)
            {
                return NotFound(); // Handle the case when the blog with the specified ID is not found
            }

            return View(writer);
        }

        [HttpPost]
        public IActionResult SaveUpdatedWriter(Writer updatedWriter)
        {
            var adminrepo = new AdminRepo();
            if (adminrepo.SaveUpdatedWriter(updatedWriter))
            //if (writerrepo.DeleteBlog(id))
            {
                return RedirectToAction("Dashboard", "Admin");

            }
            return View();

        }


    }
}
