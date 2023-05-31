using Microsoft.EntityFrameworkCore;
using Blogistaan.Models;
using System.Linq;


namespace Blogistaan.Repository
{
    public class WriterRepo
    {
        private ContextClass dbContext;
        public WriterRepo(ContextClass dbContext)
        {
            this.dbContext = dbContext;
        }
        //Writer writerobj = new Writer();
    
        public bool ValidateLogin(string username, string password)
        {
            return dbContext.Writers.Any(w => w.Username == username && w.Password == password);

            //return dbContext.Writers.Any(x => x.Va)
        }



    }
}
