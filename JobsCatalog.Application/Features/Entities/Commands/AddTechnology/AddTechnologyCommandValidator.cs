using FluentValidation;
using JobsCatalog.Application.Contracts.Persistance;
using JobsCatalog.Application.Features.Entities.Commands.UpdateJob;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Entities.Commands.AddTechnology
{
    public class AddTechnologyCommandValidator : AbstractValidator<AddTechnologyCommand>
    {
        private readonly IJobsCatalogDbContext _dbcontext;

        public AddTechnologyCommandValidator(IJobsCatalogDbContext dbContext)
        {
            _dbcontext = dbContext;
            RuleFor(command => command.JobOfferId).Custom((jobOfferId, context) =>
            {
                var jobOffer = _dbcontext.JobOffers.Where(x => x.Id == jobOfferId).Any();
                if (jobOffer is false)
                {
                    context.AddFailure($"JobOffer with id: {jobOfferId} does not exist in db");
                }
            });
            RuleFor(command => command.Technologies).Custom((technologies, context) =>
            {
                technologies.ForEach(x =>
                {
                    if (x < 0)
                    {
                        context.AddFailure($"Technology id must be greater then 0, error caused by {x} value");
                    }
                });

                technologies.GroupBy(x => x).Select(x => new
                {
                    x.Key,
                    Amount = x.Count()
                }).ToList().ForEach(x => 
                {
                    if(x.Amount > 1)
                    {
                        context.AddFailure($"Technology id {x.Key} has been added to request {x.Amount} times, input unique value");
                    }
                });
            });
            RuleFor(command => command).Custom((command, context) =>
            {
                var joT = _dbcontext.JobOfferTechnologies.Where(x => x.JobOfferId == command.JobOfferId)
                    .Select(x => x.TechnologyId).ToList();

                command.Technologies.ForEach(techId =>
                {
                    if(joT.Contains(techId))
                    {
                        context.AddFailure($"Technology with id {techId} has been already added to job identify by {command.JobOfferId}");
                    }
                });
            });
        }
    }
}
