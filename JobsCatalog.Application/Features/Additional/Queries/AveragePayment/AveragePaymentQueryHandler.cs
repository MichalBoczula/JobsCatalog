using JobsCatalog.Application.Contracts.Persistance;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Additional.Queries.AveragePayment
{
    public class AveragePaymentQueryHandler : IRequestHandler<AveragePaymentQuery, AveragePaymentVm>
    {
        private readonly IJobsCatalogDbContext _context;

        public AveragePaymentQueryHandler(IJobsCatalogDbContext context)
        {
            _context = context;
        }

        public async Task<AveragePaymentVm> Handle(AveragePaymentQuery request, CancellationToken cancellationToken)
        {
            var q1 = _context.JobOffers
                .Join(_context.ExperienceLeves,
                    jo => jo.ExperienceLevelId,
                    el => el.Id,
                    (jo, el) => new { el.Name, jo });
            var raaa = request.ExperienceLevelName;
            var raaa2 = request.ExperienceLevelName.ToLower();
            if (request.ExperienceLevelName.ToLower().Trim() != "all")
            {
                q1 = q1.Where(x => x.Name.ToLower() == request.ExperienceLevelName.ToLower().Trim());
            }

            var result = await q1.GroupBy(x => x.Name)
                .Select(x => new ExperienceLevelSalariesDto
                {
                    ExperienceLevel = x.Key,
                    AvgMinSalary = ((int)x.Average(x => x.jo.SalaryMin)),
                    AvgMaxSalary = ((int)x.Average(x => x.jo.SalaryMax))
                }).ToListAsync(cancellationToken);

            return new AveragePaymentVm() { ExperienceLevelSalariesDtos = result };
        }
    }
}
