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


        public bool ValidateAdminLogin(string username, string password)
        {
            return dbContext.Admins.Any(w => w.Username == username && w.Password == password);

            //return dbContext.Writers.Any(x => x.Va)
        }

        public List<Writer> FetchAllWriters ()
        {

            return dbContext.Writers.ToList();
        }

        public bool AddWriter(Writer writer)
        {

            dbContext.Writers.Add(writer);
            dbContext.SaveChangesAsync();
            return true;
            
        }


    }
}
