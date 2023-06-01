using Microsoft.EntityFrameworkCore;
using Blogistaan.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Blogistaan.Repository
{
    public class WriterRepo
    {
      
        ContextClass dbContext= new ContextClass();


        public int ValidateWriterLogin(string username, string password)
        {
            var writer = dbContext.Writers.SingleOrDefault(w => w.Username == username && w.Password == password);
            if (writer != null)
            {
                return writer.Id;
            }

            return 0; 
            // Or any other value that represents an invalid writer ID
        }



        public List<Blog> FetchAllBlogsFromWriter(int id)
        {
            return dbContext.Blogs.Where(b => b.Author == id).ToList();
        }



        public List<Blog> FetchAllBlogs()
        {

            return dbContext.Blogs.ToList();
        }



        public bool SaveBlog(Blog blog)
        {

            dbContext.Blogs.Add(blog);
            //dbContext.Blogs.up
            dbContext.SaveChangesAsync();
            //dbContext.SaveChanges();
            return true;
        }


        public bool DeleteBlog(int id)
        {
            var blog = dbContext.Blogs.Find(id);
            if (blog != null)
            {
                dbContext.Blogs.Remove(blog);
                dbContext.SaveChanges();
                return true;
            }
            return false;

        }

        public Blog FetchBlogbyID(int id)
        {

            var blog = dbContext.Blogs.FirstOrDefault(w => w.Id == id);
            if (blog != null)
            {
                return blog;

            }
            else
                return blog;

        }

        public bool SaveUpdatedBlog(Blog blog)
        {
            var blog1 = dbContext.Blogs.FirstOrDefault(w => w.Id == blog.Id);

            // Update the properties of the retrieved blog with the new values
            blog1.Title = blog.Title;
            blog1.ShortDescription = blog.ShortDescription;
            blog1.Content = blog.Content;

            // Save the changes to the database
            dbContext.SaveChanges();
            return true;
        }
    }
}
