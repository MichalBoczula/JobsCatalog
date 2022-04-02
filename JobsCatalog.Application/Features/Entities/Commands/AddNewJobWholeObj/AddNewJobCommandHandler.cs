using AutoMapper;
using JobsCatalog.Application.Contracts.Persistance;
using JobsCatalog.Application.Features.Entities.Commands;
using JobsCatalog.Domain.Entities;
using JobsCatalog.Domain.Helper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Entities.Commands.AddNewJobWholeObj
{
    public class AddNewJobCommandHandler : IRequestHandler<AddNewJobCommand, int?>
    {
        private readonly IJobsCatalogDbContext _context;
        private readonly IMapper _mapper;

        public AddNewJobCommandHandler(IJobsCatalogDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int?> Handle(AddNewJobCommand request, CancellationToken cancellationToken)
        {
            var jobOffer = _mapper.Map<JobOffer>(request.Model.JobOffer);

            _context.JobOffers.Add(jobOffer);
            var action1 = await _context.SaveChangesAsync(cancellationToken);

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
            var action2 = await _context.SaveChangesAsync(cancellationToken);

            return action1 > 0 && action2 > 0 ? jobOffer.Id : null;
        }
    }
}
