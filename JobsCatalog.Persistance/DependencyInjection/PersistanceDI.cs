using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using JobsCatalog.Persistance.Context;
using JobsCatalog.Application.Contracts.Persistance;

namespace JobsCatalog.Persistance.DependencyInjection
{
    public static class PersistanceDI
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<JobsCatalogDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Production")));
            services.AddScoped<IJobsCatalogDbContext, JobsCatalogDbContext>();
            return services;
        }
    }
}
