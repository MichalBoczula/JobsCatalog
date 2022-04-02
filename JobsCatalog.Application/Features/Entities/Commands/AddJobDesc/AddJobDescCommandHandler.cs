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

namespace JobsCatalog.Application.Features.Entities.Commands.AddJobDesc
{
    public class AddJobDescCommandHandler : IRequestHandler<AddJobDescCommand, int?>
    {
        private readonly IJobsCatalogDbContext _context;
        private readonly IMapper _mapper;

        public AddJobDescCommandHandler(IJobsCatalogDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int?> Handle(AddJobDescCommand request, CancellationToken cancellationToken)
        {
            var jobDesc = _mapper.Map<JobDescription>(request.Model);
            jobDesc.JobOfferId = request.JobOfferId;
            _context.JobDescriptions.Add(jobDesc);
            var result = await _context.SaveChangesAsync(cancellationToken);
            return result > 0 ? jobDesc.Id : null;
        }
    }
}
