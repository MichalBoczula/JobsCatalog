using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Additional.Queries
{
    public class AveragePaymentQueryValidator : AbstractValidator<AveragePaymentQuery>
    {
        public AveragePaymentQueryValidator()
        {
            RuleFor(x => x.ExperienceLevelName).NotEmpty();
        }
    }
}
