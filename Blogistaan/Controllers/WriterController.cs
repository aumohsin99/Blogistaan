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
            // Get the writer ID from the cookie
            if (HttpContext.Request.Cookies.TryGetValue("WriterId", out string writerIdString))
            {
                if (int.TryParse(writerIdString, out int writerId))
                {
                    var writerrepo = new WriterRepo();

                    // Use the writer ID as needed
                    // For example, retrieve the writer from the repository using the ID

                    //var writer = writerrepo.GetWriterById(writerId);


                    //var writerrepo = new WriterRepo();
                    var listofBlogs = writerrepo.FetchAllBlogsFromWriter(writerId);

                    return View(listofBlogs);

                    // Other logic...
                }
                else
                {
                    return View();
                }
                //else
                //{
                //    return Redirect("Home");
                //}
            }
            else
            {
                return View();
            }

            // Rest of the action method...
        }


        //[HttpGet]
        //public IActionResult Dashboard()
        //{
        //    var writerrepo = new WriterRepo();
        //    var listofBlogs = writerrepo.FetchAllBlogs();

        //    return View(listofBlogs);
        //}

        public IActionResult WriteBlog()
        {
            return View();
        }


    }
}
