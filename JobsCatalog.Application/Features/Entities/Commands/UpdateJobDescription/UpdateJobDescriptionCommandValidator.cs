using FluentValidation;
using JobsCatalog.Application.Contracts.Persistance;
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
            RuleFor(x => x.JobOfferId).Custom((jobOfferId, context) =>
            {
                var jobOffer = _dbcontext.JobOffers.SingleOrDefault(x => x.Id == jobOfferId);
                if(jobOffer is null)
                {
                    context.AddFailure($"JobOffer with id: {jobOfferId} does nott exist in db");
                }
            });
            RuleFor(x => x.Model.About).NotEmpty();
            RuleFor(x => x.Model.Expectation).NotEmpty();
            RuleFor(x => x.Model.Responsibilities).NotEmpty();
            RuleFor(x => x.Model.Offer).NotEmpty();
        }
    }
}
