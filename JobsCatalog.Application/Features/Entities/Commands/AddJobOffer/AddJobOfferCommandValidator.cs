using FluentValidation;
using JobsCatalog.Application.Contracts.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Entities.Commands.AddJobOffer
{
  public class AddJobOfferCommandValidator : AbstractValidator<AddJobOfferCommand>
    {
        private readonly IJobsCatalogDbContext _dbcontext;

        public AddJobOfferCommandValidator(IJobsCatalogDbContext dbContext)
        {
            _dbcontext = dbContext;
            RuleFor(x => x.Model.PositionName).NotEmpty();
            RuleFor(x => x.Model.SalaryMin).GreaterThanOrEqualTo(2800);
            RuleFor(x => x.Model).Custom((model, context) =>
            {
                if (model.SalaryMin > model.SalaryMax)
                {
                    context.AddFailure("SalaryMax must be bigger than SalaryMin");
                }
            });
            RuleFor(x => x.Model.City).NotEmpty();
            RuleFor(x => x.Model.ExperienceLevelId).Custom((expId, context) =>
            {
                var ele = _dbcontext.ExperienceLeves
                    .SingleOrDefault(x => x.Id == expId);
                if (ele == null)
                {
                    context.AddFailure("ExperienceLevel must exists in dictionary");
                }
            });
            RuleFor(x => x.Model.CompanyId).Custom((comId, context) =>
            {
                var ele = _dbcontext.Companies
                    .SingleOrDefault(x => x.Id == comId);
                if (ele == null)
                {
                    context.AddFailure("Company must exists in dataBase");
                }
            });
            RuleFor(x => x.Model.ProgrammingLanguageId).Custom((plId, context) =>
            {
                var ele = _dbcontext.ProgrammingLanguages
                    .SingleOrDefault(x => x.Id == plId);
                if (ele == null)
                {
                    context.AddFailure("ProgrammingLanguage must exists in dictionary");
                }
            });
        }
    }
}
