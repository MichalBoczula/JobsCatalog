using AutoMapper;
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
        private readonly IMapper _mapper;

        public AddNewJobCommandHandler(IJobsCatalogDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int> Handle(AddNewJobCommand request, CancellationToken cancellationToken)
        {
            try
            {
                if(request.IsProductionMode)
                {
                    await _context.BeginTransaction();
                }

                var jobOffer = _mapper.Map<JobOffer>(request.Model.JobOffer);
                    
                _context.JobOffers.Add(jobOffer);
                await _context.SaveChangesAsync(cancellationToken);

                var jobDescription = _mapper.Map<JobDescription>(request.Model.JobDescritpion);
                jobDescription.JobOfferId = jobOffer.Id;

                var technologies = request.Model.Technologies
                    .Select(x => new JobOfferTechnology
                    {
                        JobOfferId = jobOffer.Id,
                        TechnologyId = x
                    }).ToList();

                _context.JobDescriptions.Add(jobDescription);
                _context.JobOfferTechnologies.AddRange(technologies);
                await _context.SaveChangesAsync(cancellationToken);

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
