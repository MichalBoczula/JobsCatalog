using FluentValidation;
using JobsCatalog.Application.Contracts.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Entities.Commands.DeleteTechnology
{
    public class DeleteTechnologyCommandValidator : AbstractValidator<DeleteTechnologyCommand>
    {
        private readonly IJobsCatalogDbContext _dbcontext;

        public DeleteTechnologyCommandValidator(IJobsCatalogDbContext dbContext)
        {
            _dbcontext = dbContext;
            RuleFor(command => command.JobOfferId).Custom((jobOfferId, context) =>
            {
                var jobOffer = _dbcontext.JobOffers.Any(x => x.Id == jobOfferId);
                if (jobOffer is false)
                {
                    context.AddFailure($"JobOffer with id: {jobOfferId} does not exist in db");
                }
            });
            RuleFor(command => command.TechnologyId).Custom((technology, context) =>
            {
                if (technology < 0)
                {
                    context.AddFailure($"Technology id has to be greater then 0, error caused by {technology} value");
                }
            });
            RuleFor(command => command).Custom((command, context) =>
            {
                var joT = _dbcontext.JobOfferTechnologies.Where(x => x.JobOfferId == command.JobOfferId)
                    .Select(x => x.TechnologyId).ToList();

                if (joT.Contains(command.TechnologyId) == false)
                {
                    context.AddFailure($"Technology with id {command.TechnologyId} does not exist in job identify by {command.JobOfferId}");
                }
            });
        }
    }
}
