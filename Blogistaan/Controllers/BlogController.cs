using Blogistaan.Repository;
using Blogistaan.ViewComponents;
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



            return ViewComponent(typeof(BlogViewComponent), id);

            //return View(blog);
        }

    }
}



