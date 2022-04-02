using AutoMapper;
using JobsCatalog.Application.Contracts.Persistance;
using JobsCatalog.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Entities.Commands.AddJobOffer
{
    public class AddJobOfferCommandHandler : IRequestHandler<AddJobOfferCommand, int?>
    {
        private readonly IJobsCatalogDbContext _context;
        private readonly IMapper _mapper;

        public AddJobOfferCommandHandler(IJobsCatalogDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int?> Handle(AddJobOfferCommand request, CancellationToken cancellationToken)
        {
            var jobOffer = _mapper.Map<JobOffer>(request.Model);
            _context.JobOffers.Add(jobOffer);
            var result = await _context.SaveChangesAsync(cancellationToken);
            return result > 0 ? jobOffer.Id : null;
        }
    }
}
