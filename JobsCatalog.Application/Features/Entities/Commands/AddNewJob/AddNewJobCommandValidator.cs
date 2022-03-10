using FluentValidation;
using JobsCatalog.Application.Contracts.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Entities.Commands.AddNewJob
{
    public class AddNewJobCommandValidator : AbstractValidator<AddNewJobCommand>
    {
        private readonly IJobsCatalogDbContext _dbcontext;

        public AddNewJobCommandValidator(IJobsCatalogDbContext dbContext)
        {
            _dbcontext = dbContext;
            RuleFor(x => x.Model.PositionName).NotEmpty();
            RuleFor(x => x.Model.SalaryMin).GreaterThanOrEqualTo(2800);
            RuleFor(x => x.Model).Custom((model, context) =>
            {
                if (model.SalaryMin > model.SalaryMax)
                {
                    context.AddFailure("SalaryMax has to be bigger than SalaryMin");
                }
            });
            RuleFor(x => x.Model.City).NotEmpty();
            RuleFor(x => x.Model.ExperienceLevelId).Custom((expId, context) =>
            {
                var ele = _dbcontext.ExperienceLeves
                    .SingleOrDefault(x => x.Id == expId);
                if (ele == null)
                {
                    context.AddFailure("ExperienceLevel has to exist in dictionary");
                }
            });
            RuleFor(x => x.Model.CompanyId).Custom((comId, context) =>
            {
                var ele = _dbcontext.Companies
                    .SingleOrDefault(x => x.Id == comId);
                if (ele == null)
                {
                    context.AddFailure("Company has to exists in dataBase");
                }
            });
            RuleFor(x => x.Model.ProgrammingLanguageId).Custom((plId, context) =>
            {
                var ele = _dbcontext.ProgrammingLanguages
                    .SingleOrDefault(x => x.Id == plId);
                if (ele == null)
                {
                    context.AddFailure("ProgrammingLanguage has to exist in dictionary");
                }
            });
            RuleFor(x => x.Model.About).NotEmpty();
            RuleFor(x => x.Model.Responsibilities).NotEmpty();
            RuleFor(x => x.Model.Expectation).NotEmpty();
            RuleFor(x => x.Model.Offer).NotEmpty();
            RuleFor(x => x.Model.Technologies.Count).GreaterThan(0);
            RuleFor(x => x.Model.Technologies).Custom((list, context) =>
            {
                var technologies = _dbcontext.ProgrammingLanguages
                .Where(x => list.Contains(x.Id))
                .Select(x => x.Id)
                .ToList();
                list.ForEach(x =>
                {
                    if (technologies.Contains(x) == false)
                    {
                        context.AddFailure($"Technology {x} doesn't exist in dictionary");
                    }
                });
            });
        }
    }
}
