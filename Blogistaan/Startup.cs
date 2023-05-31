using Blogistaan.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using Microsoft.AspNetCore.Hosting;

//namespace Blogistaan
//{
//    public class Startup
//    {
//        public void Configure(IApplicationBuilder app)
//        {
//            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
//        }
//    }
//}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Blogistaan
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Register the ContextClass as a service
            services.AddDbContext<ContextClass>(options =>
                options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BlogistaanDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"));

            // Other service registrations

            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Configuration and other middleware setup
            app.UseMvc();
        }
    }
}
