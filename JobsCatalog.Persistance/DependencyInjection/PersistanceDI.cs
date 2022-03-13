using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobsCatalog.Persistance.Context;
using JobsCatalog.Application.Contracts.Persistance;

namespace JobsCatalog.Persistance.DependencyInjection
{
    public static class PersistanceDI
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<JobsCatalogDbContextTransaction>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Production")));
            services.AddDbContext<JobsCatalogDbContextQuery>(options =>
            {
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                options.UseSqlServer(configuration.GetConnectionString("Production"));
            });
            services.AddScoped<IJobsCatalogDbContextTransaction, JobsCatalogDbContextTransaction>();
            services.AddScoped<IJobsCatalogDbContextQuery, JobsCatalogDbContextQuery>();
            return services;
        }
    }
}
