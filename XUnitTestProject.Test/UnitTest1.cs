using System;
using Xunit;
using Microsoft.Extensions.DependencyInjection;
using WebApplication1;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore.InMemory;

namespace XUnitTestProject.Test
{
    public class TestStartup
    {
        
        public void ConfigurationServices(IServiceCollection services)
        {
            var inMemorySqlite = new SqliteConnection("Data Source=:memory:");
            inMemorySqlite.Open();
            services.AddMvc();
            services.AddDbContext<F5DbContext>(options => options.UseSqlite(inMemorySqlite,b=>b.MigrationsAssembly("WebApplication")));

            Startup.AddSharedServices(services);
        }
    }
}
