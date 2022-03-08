using FluentValidation;

namespace JobsCatalog.Application.Features.Entities.Commands.AddNewJob
{
    public class AddNewJobCommandValidator : AbstractValidator<AddNewJobCommand>
    {
        public AddNewJobCommandValidator()
        {
            RuleFor(x => x.Model.PositionName).NotEmpty();
            RuleFor(x => x.Model.SalaryMin).GreaterThanOrEqualTo(2800);
            RuleFor(x => x.Model.SalaryMax).GreaterThanOrEqualTo(2800);
            RuleFor(x => x.Model.City).NotEmpty();
            RuleFor(x => x.Model.ExperienceLevelId).GreaterThan(0).LessThan(5);
            RuleFor(x => x.Model.CompanyId).NotNull();
            RuleFor(x => x.Model.ProgrammingLanguageId).NotNull();
            RuleFor(x => x.Model.About).NotEmpty();
            RuleFor(x => x.Model.Responsibilities).NotEmpty();
            RuleFor(x => x.Model.Expectation).NotEmpty();
            RuleFor(x => x.Model.Offer).NotEmpty();
            RuleFor(x => x.Model.Technologies.Count).GreaterThan(0);
        }
    }
}
