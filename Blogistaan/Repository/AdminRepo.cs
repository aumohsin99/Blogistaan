using Microsoft.EntityFrameworkCore;
using Blogistaan.Models;
using System.Linq;


namespace Blogistaan.Repository
{
    public class AdminRepo
    {
        //private ContextClass dbContext;
        //public WriterRepo(ContextClass dbContext)
        //{
        //    this.dbContext = dbContext;
        //}
        //Writer writerobj = new Writer();
        ContextClass dbContext= new ContextClass();


        public int ValidateAdminLogin(string username, string password)
        {
            var admin = dbContext.Admins.SingleOrDefault(w => w.Username == username && w.Password == password);

            if (admin!= null)
            {
                return admin.Id;
            }
            return 0;
            //return dbContext.Writers.Any(x => x.Va)
        }

        public List<Writer> FetchAllWriters ()
        {

            return dbContext.Writers.ToList();
        }

        public bool AddWriter(Writer writer)
        {
            var writerFound = dbContext.Writers.Find();



            dbContext.Writers.Add(writer);
            dbContext.SaveChangesAsync();
            return true;
            
        }

        public bool DeleteWriter(int id)
        {
            var writer = dbContext.Writers.Find(id);
            int writerID = writer.Id;
            //var blogs = dbContext.Blogs.Find(writerID);
            if (writer != null)
            {
                dbContext.Writers.Remove(writer);
/*                dbContext.Blogs.Remove(writerID);*/
                var pBlogs = dbContext.Blogs.Where(b => b.Author == writer.Id).ToList();
                foreach (var item in pBlogs)
                {
                    dbContext.Blogs.Remove(item);
                }

                dbContext.SaveChanges();
                return true;
            }
            return false;



        }


        public Writer FetchWriterbyID(int id)
        {

            var writer = dbContext.Writers.FirstOrDefault(w => w.Id == id);
            if (writer != null)
            {
                return writer;

            }
            else
                return writer;

        }

        public bool SaveUpdatedWriter(Writer writer)
        {
            var writer1 = dbContext.Writers.FirstOrDefault(w => w.Id == writer.Id);

            // Update the properties of the retrieved blog with the new values
            writer1.Username = writer.Username;
            writer1.Password = writer.Password;
            //blog1.Content = blog.Content;

            // Save the changes to the database
            dbContext.SaveChanges();
            return true;
        }


    }
}
