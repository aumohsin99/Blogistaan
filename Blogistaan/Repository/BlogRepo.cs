using Blogistaan.Models;
using Microsoft.EntityFrameworkCore;

namespace Blogistaan.Repository
{
    public class BlogRepo
    {
        ContextClass dbContext = new ContextClass();

        public Blog BlogRead(int id)
        {
            var blog = dbContext.Blogs.FirstOrDefault(b => b.Id == id);

            return blog;

        }

    }
}
