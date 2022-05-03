using FluentValidation;
using JobsCatalog.Application.Contracts.Persistance;
using JobsCatalog.Application.Features.Entities.Commands.DeleteTechnology;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Entities.Commands.DeleteJob
{
    public class DeleteJobCommandValidator : AbstractValidator<DeleteJobCommand>
    {
        private readonly IJobsCatalogDbContext _dbcontext;

        public DeleteJobCommandValidator(IJobsCatalogDbContext dbContext)
        {
            _dbcontext = dbContext;
            RuleFor(command => command.Id).Custom((jobOfferId, context) =>
            {
                var jobOffer = _dbcontext.JobOffers.Where(x => x.Id == jobOfferId).Any();
                if (jobOffer is false)
                {
                    context.AddFailure($"JobOffer with id: {jobOfferId} does not exist in db");
                }
            });
        }
    }
}
