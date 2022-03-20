using AutoMapper;
using JobsCatalog.Application.Contracts.Persistance;
using JobsCatalog.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Entities.Commands.UpdateJobDescription
{
    public class UpdateJobDescriptionCommandHandler : IRequestHandler<UpdateJobDescriptionCommand, int?>
    {
        private readonly IJobsCatalogDbContext _context;

        public UpdateJobDescriptionCommandHandler(IJobsCatalogDbContext context)
        {
            _context = context;
        }

        public async Task<int?> Handle(UpdateJobDescriptionCommand request, CancellationToken cancellationToken)
        {
            var jobDesc = _context.JobDescriptions
                .SingleOrDefault(x => x.JobOfferId == request.JobOfferId);
            jobDesc.About = request.Model.About;
            jobDesc.Responsibilities = request.Model.Responsibilities;
            jobDesc.Offer = request.Model.Offer;
            jobDesc.Expectation = request.Model.Expectation;
            _context.JobDescriptions.Update(jobDesc);
            var result = await _context.SaveChangesAsync(cancellationToken);
            return result > 0 ? result : null;
        }
    }
}
