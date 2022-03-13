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
    public class DeleteTechnologyCommandHandler : IRequestHandler<DeleteTechnologyCommand, int>
    {
        private readonly IJobsCatalogDbContextTransaction _context;

        public DeleteTechnologyCommandHandler(IJobsCatalogDbContextTransaction context)
        {
            _context = context;
        }

        public async Task<int> Handle(DeleteTechnologyCommand request, CancellationToken cancellationToken)
        {
            var techsToRemove = request.Technologies
                .Distinct()
                .Join(_context.JobOfferTechnologies,
                tId => tId,
                jt => jt.TechnologyId,
                (tId, jt) => new { tId, jt.JobOfferId})
                .Where(x => x.JobOfferId == request.JobOfferId)
                .Select(x => new JobOfferTechnology
                {
                    JobOfferId = request.JobOfferId,
                    TechnologyId = x.tId
                }).ToList();
            _context.JobOfferTechnologies.RemoveRange(techsToRemove);
            var result = await _context.SaveChangesAsync(cancellationToken);
            return result;
        }
    }
}
