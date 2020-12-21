using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SinavOlusturma.Model.Context;
using System.IO;

namespace SinavOlusturma.Service.Tools
{
    public class DesingTimeDbContextFactory : IDesignTimeDbContextFactory<ProjectContext>
    {
        public ProjectContext CreateDbContext(string[] args)
        {
            /*
             connectionstring kullanabilmek için iconfuration tipinde  configurationbuilder'dan intance alınır.
             bunun yerine:  
             builder.usesqlserver("data source=.;initial catalog=db; user id=.;password=.;"); şeklinde de yazılabilir.  

             Build edildiğinde ProjectContext tipinde bir nesneyi çalıştırır. Buna tekrar bak
             */

            DbContextOptionsBuilder<ProjectContext> builder = new DbContextOptionsBuilder<ProjectContext>();
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../SinavOlusturma"))
                .AddJsonFile("appsettings.json")
                .Build();
            builder.UseSqlServer(config.GetConnectionString("myconnection"));
            return new ProjectContext(builder.Options);
        }
    }
}
