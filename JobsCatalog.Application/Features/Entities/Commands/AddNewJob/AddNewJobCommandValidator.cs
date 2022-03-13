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
            RuleFor(x => x.Model.JobOffer.PositionName).NotEmpty();
            RuleFor(x => x.Model.JobOffer.SalaryMin).GreaterThanOrEqualTo(2800);
            RuleFor(x => x.Model.JobOffer).Custom((model, context) =>
            {
                if (model.SalaryMin > model.SalaryMax)
                {
                    context.AddFailure("SalaryMax has to be bigger than SalaryMin");
                }
            });
            RuleFor(x => x.Model.JobOffer.City).NotEmpty();
            RuleFor(x => x.Model.JobOffer.ExperienceLevelId).Custom((expId, context) =>
            {
                var ele = _dbcontext.ExperienceLeves
                    .SingleOrDefault(x => x.Id == expId);
                if (ele == null)
                {
                    context.AddFailure("ExperienceLevel has to exist in dictionary");
                }
            });
            RuleFor(x => x.Model.JobOffer.CompanyId).Custom((comId, context) =>
            {
                var ele = _dbcontext.Companies
                    .SingleOrDefault(x => x.Id == comId);
                if (ele == null)
                {
                    context.AddFailure("Company has to exists in dataBase");
                }
            });
            RuleFor(x => x.Model.JobOffer.ProgrammingLanguageId).Custom((plId, context) =>
            {
                var ele = _dbcontext.ProgrammingLanguages
                    .SingleOrDefault(x => x.Id == plId);
                if (ele == null)
                {
                    context.AddFailure("ProgrammingLanguage has to exist in dictionary");
                }
            });
            RuleFor(x => x.Model.JobDescritpion.About).NotEmpty();
            RuleFor(x => x.Model.JobDescritpion.Responsibilities).NotEmpty();
            RuleFor(x => x.Model.JobDescritpion.Expectation).NotEmpty();
            RuleFor(x => x.Model.JobDescritpion.Offer).NotEmpty();
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
