using FluentAssertions;
using JobsCatalog.Application.Features.Entities.Queries.JobDetails;
using JobsCatalog.Domain.Entities;
using JobsCatalog.Persistance.Context;
using JobsCatalog.UnitTests.Common.TestBases;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace JobsCatalog.UnitTests.Features.Entities.Queries.Details
{
    [Collection("QueryCollection")]
    public class JobDetailsQueryHandlerTests
    {
        private readonly JobsCatalogDbContextTransaction _context;

        public JobDetailsQueryHandlerTests(QueryTestBase testBase)
        {
            _context = testBase.ContextTransaction;
        }

        [Fact]
        public async Task ShouldReturnObject()
        {
            var handler = new JobDetailsQueryHandler(_context);
            var result = await handler.Handle(new JobDetailsQuery() { Id = 1 }, CancellationToken.None);
            result.Should().BeOfType<JobDetailsVm>();
            result.Id.Should().BeGreaterThan(0);
            result.PositionName.Should().NotBeNullOrWhiteSpace();
            result.SalaryMin.Should().BeGreaterThanOrEqualTo(2800);
            result.SalaryMax.Should().BeGreaterThanOrEqualTo(2800);
            result.City.Should().NotBeNullOrWhiteSpace();
            result.CompanyName.Should().NotBeNullOrWhiteSpace();
            result.CompanyImage.Should().NotBeNullOrWhiteSpace();
            result.ProgrammingLanguageImage.Should().NotBeNullOrWhiteSpace();
            result.About.Should().NotBeNullOrWhiteSpace();
            result.Responsibilities.Should().NotBeNullOrWhiteSpace();
            result.Expectation.Should().NotBeNullOrWhiteSpace();
            result.Offer.Should().NotBeNullOrWhiteSpace();
            result.Technologies.Should().HaveCount(3);
            result.Technologies.ForEach(x =>
            {
                x.Should().NotBeNullOrWhiteSpace();
            });
        }

        [Fact]
        public async Task ShouldReturnNull()
        {
            var handler = new JobDetailsQueryHandler(_context);
            var result = await handler.Handle(new JobDetailsQuery() { Id = 111 }, CancellationToken.None);
            result.Should().BeNull();
        }
    }
}
