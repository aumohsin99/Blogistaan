using Microsoft.AspNetCore.Mvc;

namespace Blogistaan.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Chat()
        {
            return View();
        }
    }
}
