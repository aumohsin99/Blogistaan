using Microsoft.AspNetCore.Mvc;

namespace Blogistaan.Controllers
{
    public class WriterController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult WriteBlog()
        {
            return View();
        }


    }
}
