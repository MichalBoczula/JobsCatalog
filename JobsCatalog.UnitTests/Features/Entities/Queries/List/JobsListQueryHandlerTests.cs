using FluentAssertions;
using JobsCatalog.Application.Features.Entities.Queries.JobsList;
using JobsCatalog.Persistance.Context;
using JobsCatalog.UnitTests.Common.TestBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace JobsCatalog.UnitTests.Features.Entities.Queries.List
{
    [Collection("QueryCollection")]
    public class JobsListQueryHandlerTests
    {
        private readonly JobsCatalogDbContextTransaction _context;

        public JobsListQueryHandlerTests(QueryTestBase testBase)
        {
            _context = testBase.ContextTransaction;
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
