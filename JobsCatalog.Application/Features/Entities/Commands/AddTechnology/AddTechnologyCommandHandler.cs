using JobsCatalog.Application.Contracts.Persistance;
using JobsCatalog.Domain.Helper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Entities.Commands.AddTechnology
{
    public class AddTechnologyCommandHandler : IRequestHandler<AddTechnologyCommand, List<int>>
    {
        private readonly IJobsCatalogDbContextTransaction _context;

        public AddTechnologyCommandHandler(IJobsCatalogDbContextTransaction context)
        {
            _context = context;
        }

        public async Task<List<int>> Handle(AddTechnologyCommand request, CancellationToken cancellationToken)
        {
            var entry = request.Technologies
                .Select(x => new JobOfferTechnology
                {
                    JobOfferId = request.JobOfferId,
                    TechnologyId = x
                });

            _context.JobOfferTechnologies.AddRange(entry.ToList());
            var result = await _context.SaveChangesAsync(cancellationToken);

            return result > 0 ? request.Technologies : null;
        }
    }
}
