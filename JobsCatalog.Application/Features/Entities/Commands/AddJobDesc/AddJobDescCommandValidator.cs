using FluentValidation;
using JobsCatalog.Application.Contracts.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Entities.Commands.AddJobDesc
{
    public class AddJobDescCommandValidator : AbstractValidator<AddJobDescCommand>
    {
        private readonly IJobsCatalogDbContext _dbcontext;

        public AddJobDescCommandValidator(IJobsCatalogDbContext dbContext)
        {
            _dbcontext = dbContext;
            RuleFor(x => x.Model.About).NotEmpty();
            RuleFor(x => x.Model.Expectation).NotEmpty();
            RuleFor(x => x.Model.Responsibilities).NotEmpty();
            RuleFor(x => x.Model.Offer).NotEmpty();
            RuleFor(x => x.JobOfferId).Custom((jobId, context) =>
            {
                var ele = _dbcontext.JobOffers
                    .SingleOrDefault(x => x.Id == jobId);
                if (ele == null)
                {
                    context.AddFailure("Job Offer must exists in dataBase");
                }
            });
            RuleFor(x => x.JobOfferId).Custom((jobId, context) =>
            {
                var ele = _dbcontext.JobDescriptions
                    .SingleOrDefault(x => x.JobOfferId == jobId);
                if (ele != null)
                {
                    context.AddFailure("Job Offer has had description already");
                }
            });
        }
    }
}
