using JobsCatalog.Domain.Dictionaries;
using JobsCatalog.Domain.Entities;
using JobsCatalog.Domain.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Contracts.Persistance
{
    public interface IJobsCatalogDbContextQuery
    {
        DbSet<ExperienceLevel> ExperienceLeves { get; set; }
        DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }
        DbSet<Technology> Technologies { get; set; }
        DbSet<Company> Companies { get; set; }
        DbSet<JobDescription> JobDescriptions { get; set; }
        DbSet<JobOffer> JobOffers { get; set; }
        DbSet<JobOfferTechnology> JobOfferTechnologies { get; set; }
    }
}
