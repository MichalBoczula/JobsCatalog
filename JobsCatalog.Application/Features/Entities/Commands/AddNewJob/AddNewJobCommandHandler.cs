using JobsCatalog.Application.Contracts.Persistance;
using JobsCatalog.Application.Features.Entities.Commands;
using JobsCatalog.Application.Features.Entities.Commands.AddNewJob;
using JobsCatalog.Domain.Entities;
using JobsCatalog.Domain.Helper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Entities.Commands.AddNewJob
{
    public class AddNewJobCommandHandler : IRequestHandler<AddNewJobCommand, int>
    {
        private readonly IJobsCatalogDbContext _context;

        public AddNewJobCommandHandler(IJobsCatalogDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(AddNewJobCommand request, CancellationToken cancellationToken)
        {
            try
            {
                if(request.IsProductionMode)
                {
                    await _context.BeginTransaction();
                }

                var jobOffer = new JobOffer
                {
                    PositionName = request.Model.PositionName,
                    SalaryMin = request.Model.SalaryMin,
                    SalaryMax = request.Model.SalaryMax,
                    City = request.Model.City,
                    ExperienceLevelId = request.Model.ExperienceLevelId,
                    CompanyId = request.Model.CompanyId,
                    ProgrammingLanguageId = request.Model.ProgrammingLanguageId
                };
                
                _context.JobOffers.Add(jobOffer);
                
                await _context.SaveChangesAsync(cancellationToken);

                _context.JobDescriptions.Add(
                    new JobDescription()
                    {
                        JobOfferId = jobOffer.Id,
                        About = request.Model.About,
                        Responsibilities = request.Model.Responsibilities,
                        Expectation = request.Model.Expectation,
                        Offer = request.Model.Offer
                    });

                await _context.SaveChangesAsync(cancellationToken);

                var technologies = request.Model.Technologies
                    .Select(x=> new JobOfferTechnology
                    {
                        JobOfferId = jobOffer.Id,
                        TechnologyId = x
                    });

                _context.JobOfferTechnologies.AddRange(technologies);

                if (request.IsProductionMode)
                {
                    await _context.CommitTransaction(cancellationToken);
                }

                return jobOffer.Id;
            }
            catch
            {
                await _context.RollbackTransaction(cancellationToken);
                return -1;
            }

        }
    }
}
