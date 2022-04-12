using JobsCatalog.Application.Contracts.Persistance;
using JobsCatalog.Persistance.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace JobsCatalog.IntegrationTests.Common
{
    public class MyWebApplicationFactory<TStartup> : WebApplicationFactory<TStartup>
        where TStartup : class
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {

            builder.ConfigureServices(services =>
            {
                //var builder = new ConfigurationBuilder();
                //var configuration = builder.Build();

                var serviceProvider = new ServiceCollection()
                        .AddEntityFrameworkInMemoryDatabase()
                        .BuildServiceProvider();

                services.AddDbContext<JobsCatalogDbContext>(options =>
                {
                    options.UseInMemoryDatabase("InMemoryDbForTesting");
                    options.UseInternalServiceProvider(serviceProvider);
                });

                services.AddScoped<IJobsCatalogDbContext>(provider => provider.GetService<JobsCatalogDbContext>());
                var createServices = services.BuildServiceProvider();

                using var serviceScope = createServices.CreateScope();
                var scopedServices = serviceScope.ServiceProvider;
                var context = scopedServices.GetRequiredService<JobsCatalogDbContext>();
                var logger = scopedServices.GetRequiredService<ILogger<MyWebApplicationFactory<TStartup>>>();

                context.Database.EnsureCreated();
            }).UseSerilog();
        }
    }
}
