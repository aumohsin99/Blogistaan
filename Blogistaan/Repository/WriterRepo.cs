using Microsoft.EntityFrameworkCore;
using Blogistaan.Models;
using System.Linq;


namespace Blogistaan.Repository
{
    public class WriterRepo
    {
        //private ContextClass dbContext;
        //public WriterRepo(ContextClass dbContext)
        //{
        //    this.dbContext = dbContext;
        //}
        //Writer writerobj = new Writer();
        ContextClass dbContext= new ContextClass();


        //public bool ValidateWriterLogin(string username, string password)
        //{
        //    return dbContext.Writers.Any(w => w.Username == username && w.Password == password);

        //}


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


        public int idForCookies()
        {
            int id = 0;


            return id;
        }
    }
}
