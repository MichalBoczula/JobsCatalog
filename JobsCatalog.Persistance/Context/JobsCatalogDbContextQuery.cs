using JobsCatalog.Application.Contracts.Persistance;
using JobsCatalog.Domain.Dictionaries;
using JobsCatalog.Domain.Entities;
using JobsCatalog.Domain.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace JobsCatalog.Persistance.Context
{
    public class JobsCatalogDbContextQuery : DbContext, IJobsCatalogDbContextQuery
    {
        public DbSet<ExperienceLevel> ExperienceLeves { get; set; }
        public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }
        public DbSet<Technology> Technologies { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<JobDescription> JobDescriptions { get; set; }
        public DbSet<JobOffer> JobOffers { get; set; }
        public DbSet<JobOfferTechnology> JobOfferTechnologies { get; set; }

        public JobsCatalogDbContextQuery([NotNull] DbContextOptions<JobsCatalogDbContextQuery> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
