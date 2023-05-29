using Microsoft.EntityFrameworkCore;
using System.Collections.Concurrent;

namespace Blogistaan.Models
{
    public class ContextClass : DbContext
    {
        DbSet<Admin> Admins { get; set; }
        DbSet<Blog> Blogs { get; set; }
        DbSet<Writer> Writers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BlogistaanDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            //base.OnConfiguring(optionsBuilder);
        }

    }
}
