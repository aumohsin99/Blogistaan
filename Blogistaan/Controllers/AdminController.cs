using Blogistaan.Repository;
using Microsoft.AspNetCore.Mvc;

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
