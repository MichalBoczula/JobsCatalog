using MediatR;

namespace JobsCatalog.Application.Features.Additional.Queries.AveragePayment
{
    public class AveragePaymentQuery : IRequest<AveragePaymentVm>
    {
        public string ExperienceLevelName { get; set; }
    }
}
