using Blogistaan.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Blogistaan.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Home()
        {

            var writerreop = new WriterRepo();
            var listofBlogs = writerreop.FetchAllBlogs();

            return View(listofBlogs);
            //return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //public IActionResult Blog()
        //{
        //    return View();
        //}

    }
}
