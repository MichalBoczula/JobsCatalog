using JobsCatalog.Application.Contracts.Persistance;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Entities.Commands.DeleteJob
{
    public class DeleteJobCommandHandler : IRequestHandler<DeleteJobCommand, int?>
    {
        private readonly IJobsCatalogDbContext _context;

        public DeleteJobCommandHandler(IJobsCatalogDbContext context)
        {
            _context = context;
        }

        public async Task<int?> Handle(DeleteJobCommand request, CancellationToken cancellationToken)
        {
            var jobOffer = _context.JobOffers.SingleOrDefault(x => x.Id == request.Id);
            _context.JobOffers.Remove(jobOffer);

            var jobDesc = _context.JobDescriptions.SingleOrDefault(x => x.JobOfferId == request.Id);
            if(jobDesc is not null)
            {
                _context.JobDescriptions.Remove(jobDesc);
            }

            var result = await _context.SaveChangesAsync(cancellationToken);

            return result > 0 ? result : null;
        }
    }
}
