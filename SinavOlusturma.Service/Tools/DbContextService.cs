using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SinavOlusturma.Model.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace SinavOlusturma.Service.Tools
{
   static class DbContextService
    {
        public static IServiceCollection AddDbContextService(this IServiceCollection services)
        {
            // Project Context'i ulaşılabilir hale getirir. Buna tekrar bak 

            ServiceProvider provider = services.BuildServiceProvider();
            IConfiguration configuration = provider.GetService<IConfiguration>();

            services.AddDbContext<ProjectContext>(x => x.UseSqlServer("Data Source=DESKTOP-3VCBFAJ;Initial Catalog=KonusarakOgren; User Id=user;Password=1234;"));
            return services;
        }
    }
}
