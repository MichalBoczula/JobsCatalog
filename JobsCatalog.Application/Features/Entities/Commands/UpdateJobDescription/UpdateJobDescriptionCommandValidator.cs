using FluentValidation;
using JobsCatalog.Application.Contracts.Persistance;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Entities.Commands.UpdateJobDescription
{
    public class UpdateJobDescriptionCommandValidator : AbstractValidator<UpdateJobDescriptionCommand>
    {
        private readonly IJobsCatalogDbContext _dbcontext;

        public UpdateJobDescriptionCommandValidator(IJobsCatalogDbContext dbContext)
        {
            _dbcontext = dbContext;
            RuleFor(x => x.Model.About).NotEmpty();
            RuleFor(x => x.Model.Expectation).NotEmpty();
            RuleFor(x => x.Model.Responsibilities).NotEmpty();
            RuleFor(x => x.Model.Offer).NotEmpty();
            RuleFor(x => x.JobOfferId).Custom((jobOfferId, context) =>
            {
                var jobOffer = _dbcontext.JobOffers.Where(x => x.Id == jobOfferId).Any();
                if (jobOffer is false)
                {
                    context.AddFailure($"JobOffer with id: {jobOfferId} does not exist in db");
                }
            });
            RuleFor(x => x.JobOfferId).Custom((jobOfferId, context) =>
            {
                var jobDesc = _dbcontext.JobDescriptions.Where(x => x.JobOfferId == jobOfferId).Any();
                if (jobDesc is false)
                {
                    context.AddFailure($"JobDesc for JobOffer with Id: {jobOfferId} does not exist in db");
                }
            });
        }
    }
}
