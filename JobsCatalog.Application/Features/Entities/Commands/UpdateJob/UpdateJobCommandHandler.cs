using JobsCatalog.Application.Contracts.Persistance;
using JobsCatalog.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Entities.Commands.UpdateJob
{
    public class UpdateJobCommandHandler : IRequestHandler<UpdateJobCommand, int>
    {
        private readonly IJobsCatalogDbContext _context;

        public UpdateJobCommandHandler(IJobsCatalogDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(UpdateJobCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
