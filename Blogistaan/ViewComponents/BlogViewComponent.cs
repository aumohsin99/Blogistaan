using Blogistaan.Repository;
using Microsoft.AspNetCore.Mvc;
using Blogistaan.Models;

namespace Blogistaan.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var blogrepo = new BlogRepo();
            var blog = blogrepo.BlogRead(id);

            return View(blog);
        }
    }
}