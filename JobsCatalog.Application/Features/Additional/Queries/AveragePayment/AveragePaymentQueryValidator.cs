using FluentValidation;

namespace JobsCatalog.Application.Features.Additional.Queries.AveragePayment
{
    public class AveragePaymentQueryValidator : AbstractValidator<AveragePaymentQuery>
    {
        public AveragePaymentQueryValidator()
        {
            RuleFor(x => x.ExperienceLevelName).NotEmpty();
        }
    }
}
