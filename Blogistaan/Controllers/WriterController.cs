using Blogistaan.Models;
using Blogistaan.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Blogistaan.Controllers
{
    public class WriterController : Controller
    {
        [HttpGet]
        public IActionResult Dashboard()
        {
            var writerreop = new WriterRepo();
            var listofBlogs = writerreop.FetchAllBlogs();

            return View(listofBlogs);
        }

        public IActionResult WriteBlog()
        {
            return View();
        }


    }
}
