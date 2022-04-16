using JobsCatalog.Application.Contracts.Persistance;
using JobsCatalog.Persistance.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace JobsCatalog.IntegrationTests.Configuration
{
    public class MyWebApplicationFactory<TStartup> : WebApplicationFactory<TStartup>
        where TStartup : class
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            try
            {
                builder
                .ConfigureServices(services =>
                {
                    var serviceProvider = new ServiceCollection()
                        .AddEntityFrameworkInMemoryDatabase()
                        .BuildServiceProvider();

                    services.AddDbContext<JobsCatalogDbContext>(options =>
                    {
                        options.UseInMemoryDatabase("InMemoryDbForTesting");
                        options.UseInternalServiceProvider(serviceProvider);
                    });

                    services.AddScoped<IJobsCatalogDbContext>(provider => provider.GetService<JobsCatalogDbContext>());
                    var sp = services.BuildServiceProvider();

                    using var scope = sp.CreateScope();
                    var scopedServices = scope.ServiceProvider;
                    var context = scopedServices.GetRequiredService<JobsCatalogDbContext>();
                    var logger = scopedServices.GetRequiredService<ILogger<MyWebApplicationFactory<TStartup>>>();

                    context.Database.EnsureCreated();
                })
               .UseSerilog()
               .UseEnvironment("Test");
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<HttpClient> GetAuthenticatedClientAsync()
        {
            var client = CreateClient();
            return client;
        }
    }
}
