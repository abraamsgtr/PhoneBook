using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using FullstackPhoneBook.Infrastructures.DataLayer.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using FullstackPhoneBook.Domain.Contracts.People;
using FullstackPhoneBook.Infrastructures.DataAccess.People;
using FullstackPhoneBook.Domain.Contracts.Tags;
using FullstackPhoneBook.Infrastructures.DataAccess.Phones;
using FullstackPhoneBook.Infrastructures.DataAccess.Tags;
using FullstackPhoneBook.Domain.Contracts.Phones;

namespace FullstackPhoneBook.EndPoints.MVC
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<PhoneBookContext>(c => c.UseSqlServer(Configuration.GetConnectionString("phoneBook")));
            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<IPhoneRepository, PhoneRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                //routes.MapRoute(
                //    name: "news",
                //    template: "{controller=Home}/{action=Index}/{id}/{slug}");

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
