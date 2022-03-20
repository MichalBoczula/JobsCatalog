using JobsCatalog.Application.Contracts.Persistance;
using JobsCatalog.Domain.Helper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Entities.Commands.DeleteTechnology
{
    public class DeleteTechnologyCommandHandler : IRequestHandler<DeleteTechnologyCommand, int?>
    {
        private readonly IJobsCatalogDbContext _context;

        public DeleteTechnologyCommandHandler(IJobsCatalogDbContext context)
        {
            _context = context;
        }

        public async Task<int?> Handle(DeleteTechnologyCommand request, CancellationToken cancellationToken)
        {
            var techsToRemove = request.Technologies
                .Select(x => new JobOfferTechnology
                {
                    JobOfferId = request.JobOfferId,
                    TechnologyId = x
                }).ToList();
            _context.JobOfferTechnologies.RemoveRange(techsToRemove);
            var result = await _context.SaveChangesAsync(cancellationToken);
            return result > 0 ? result : null;
        }
    }
}
