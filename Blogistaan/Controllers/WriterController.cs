using Blogistaan.Models;
using Blogistaan.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

                    //var writerrepo = new WriterRepo();
                    var listofBlogs = writerrepo.FetchAllBlogsFromWriter(writerId);

                    return View(listofBlogs);

                }
                else
                {
                    return View();
                }

            }
            else
            {
                return RedirectToAction("WriterLogin", "Login");
            }

        }


        [HttpPost]
        public IActionResult Logout()
        {
            if (Request.Cookies.ContainsKey("WriterId"))
            {
                Response.Cookies.Delete("WriterId");
            }

            //return RedirectToAction("Index", "Home");

            return RedirectToAction("WriterLogin", "Login");
        }


        [HttpGet]
        public IActionResult WriteBlog()
        {

            return View();
        }

        public IActionResult UpdateBlog(int id)
        {
            var writerrepo = new WriterRepo();
            var blog = writerrepo.FetchBlogbyID(id);

            
            //var blog = dbContext.Blogs.FirstOrDefault(b => b.Id == id);
            if (blog == null)
            {
                return NotFound(); // Handle the case when the blog with the specified ID is not found
            }

            return View(blog);
        }


        [HttpPost]
        public IActionResult WriteBlog(string title, string shortdescription, string content)
        {

            if (HttpContext.Request.Cookies.TryGetValue("WriterId", out string writerIdString))
            {
                if (int.TryParse(writerIdString, out int writerId))
                {
                    var blog = new Blog
                    {
                        Title = title,
                        ShortDescription = shortdescription,
                        Content = content,
                        DatePublished = DateTime.Now,
                        Author = writerId
                    };

                    var writerrepo = new WriterRepo();
                    if (writerrepo.SaveBlog(blog))
                    {
                        return RedirectToAction("Dashboard", "Writer");

                    }
                    else
                        return View();

                }
                else
                {
                    return View();
                }

            }
            else
            {
                return RedirectToAction("WriterLogin", "Login");
            }



        }


        [HttpPost]
        public IActionResult DeleteBlog(int id)
        {

            var writerrepo = new WriterRepo();
            if (writerrepo.DeleteBlog(id))
            {
                return RedirectToAction("Dashboard", "Writer");

            }
            //writerrepo.DeleteBlog(id);

            return View();

        }


        [HttpPost]
        public IActionResult SaveUpdatedBlog(Blog updatedBlog)
        {
            var writerrepo = new WriterRepo();
            if (writerrepo.SaveUpdatedBlog(updatedBlog))
            //if (writerrepo.DeleteBlog(id))
            {
                return RedirectToAction("Dashboard", "Writer");

            }
            return View();
   
        }


    }
}
