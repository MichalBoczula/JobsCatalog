using FluentAssertions;
using JobsCatalog.Application.Features.Entities.JobsList;
using JobsCatalog.Persistance.Context;
using JobsCatalog.Test.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace JobsCatalog.Test.Features.Entiteis.List
{
    [Collection("QueryCollection")]
    public class JobsListQueryHandlerTests
    {
        private readonly JobsCatalogDbContext _context;

        public JobsListQueryHandlerTests(QueryTestBase testBase)
        {
            _context = testBase.Context;
        }

        [Fact]
        public async Task ShouldReturnList()
        {
            var handler = new JobsListQueryHandler(_context);
            var result = await handler.Handle(new JobsListQuery(), CancellationToken.None);
            result.Should().HaveCount(15);
            result.Should().BeOfType<List<JobsListVm>>();
            result.ForEach(x =>
            {
                x.Id.Should().BeGreaterThan(0);
                x.PositionName.Should().NotBeNullOrWhiteSpace();
                x.SalaryMin.Should().BeGreaterThanOrEqualTo(2800);
                x.SalaryMax.Should().BeGreaterThanOrEqualTo(2800);
                x.City.Should().NotBeNullOrWhiteSpace();
                x.CompanyName.Should().NotBeNullOrWhiteSpace();
                x.CompanyImage.Should().NotBeNullOrWhiteSpace();
                x.ProgrammingLanguageImage.Should().NotBeNullOrWhiteSpace();
            });
        }
    }
}
