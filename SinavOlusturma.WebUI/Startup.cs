using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SinavOlusturma.Model.Context;
using SinavOlusturma.Service.Tools;

namespace SinavOlusturma.WebUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddMvc(x => x.EnableEndpointRouting = false);
            services.AddDbContext<ProjectContext>(options => options.UseSqlServer(Configuration.GetConnectionString("MyConnection")));
            services.AddSingleton(c => Configuration);

            services.AddDependecyService();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
           
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Exam}/{action=Index}/{id?}");
            });

            app.UseStaticFiles();

            //app.UseRouting();

            //app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapRazorPages();
            //});
        }
    }
}
