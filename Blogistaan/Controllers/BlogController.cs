using Blogistaan.Repository;
using Microsoft.AspNetCore.Mvc;



namespace Blogistaan.Controllers
{
    public class BlogController : Controller
    {

        [HttpGet]
        public IActionResult Blog(int id)
        {
            var blogrepo = new BlogRepo();
            var blog = blogrepo.BlogRead(id);

            return View(blog);
        }
    }
}



