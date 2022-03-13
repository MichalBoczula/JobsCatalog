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

namespace JobsCatalog.Application.Features.Entities.Commands.UpdateJob
{
    public class UpdateJobCommandHandler : IRequestHandler<UpdateJobCommand, int>
    {
        private readonly IJobsCatalogDbContext _context;
        private readonly IMapper _mapper;

        public UpdateJobCommandHandler(IJobsCatalogDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<int> Handle(UpdateJobCommand request, CancellationToken cancellationToken)
        {
            var entity = _mapper.Map<JobOffer>(request.Model);
            entity.Id = request.Id;
            _context.JobOffers.Update(entity);
            var result = await _context.SaveChangesAsync(cancellationToken);
            return result;
        }
    }
}
