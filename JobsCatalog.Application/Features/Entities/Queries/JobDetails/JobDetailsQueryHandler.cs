using JobsCatalog.Application.Contracts.Persistance;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Entities.Queries.JobDetails
{
    public class JobDetailsQueryHandler : IRequestHandler<JobDetailsQuery, JobDetailsVm>
    {
        private readonly IJobsCatalogDbContext _context;

        public JobDetailsQueryHandler(IJobsCatalogDbContext context)
        {
            _context = context;
        }

        public async Task<JobDetailsVm> Handle(JobDetailsQuery request, CancellationToken cancellationToken)
        {
            var technologiesList = _context.JobOfferTechnologies
                .Where(x => x.JobOfferId == request.Id)
                .Join(_context.Technologies,
                    x => x.TechnologyId,
                    t => t.Id,
                    (x, t) => t.Name);

            var vm = await _context.JobOffers
                .Where(jo => jo.Id == request.Id && jo.StatusId == 1)
                .Join(_context.Companies,
                    jo => jo.CompanyId,
                    c => c.Id,
                    (jo, c) => new { Jobs = jo, Company = c })
                .Join(_context.ProgrammingLanguages,
                    x => x.Jobs.ProgrammingLanguageId,
                    pl => pl.Id,
                    (x, pl) => new { x.Jobs, x.Company, ProgrammingLanguage = pl })
                .Join(_context.JobDescriptions,
                    x => x.Jobs.Id,
                    jd => jd.JobOfferId,
                    (x, jd) => new
                    {
                        x.Jobs,
                        x.Company,
                        x.ProgrammingLanguage,
                        JobDescription = jd
                    })
                .Join(_context.ExperienceLeves,
                    x => x.Jobs.ExperienceLevelId,
                    el => el.Id,
                    (x, el) => new
                    {
                        x.Jobs,
                        x.Company,
                        x.ProgrammingLanguage,
                        x.JobDescription,
                        ExperienceLevel= el
                    })
                .Select(x => new JobDetailsVm()
                {
                    Id = x.Jobs.Id,
                    PositionName = x.Jobs.PositionName,
                    ExperienceLevel = x.ExperienceLevel.Name,
                    SalaryMin = x.Jobs.SalaryMin,
                    SalaryMax = x.Jobs.SalaryMax,
                    City = x.Jobs.City,
                    CompanyName = x.Company.Name,
                    CompanyImage = x.Company.CompanyLogo,
                    ProgrammingLanguageImage = x.ProgrammingLanguage.Image,
                    About = x.JobDescription.About,
                    Responsibilities = x.JobDescription.Responsibilities,
                    Expectation = x.JobDescription.Expectation,
                    Offer = x.JobDescription.Offer,
                    Technologies = technologiesList.ToList()
                })
                .FirstOrDefaultAsync(cancellationToken);

            return vm;
        }
    }
}
