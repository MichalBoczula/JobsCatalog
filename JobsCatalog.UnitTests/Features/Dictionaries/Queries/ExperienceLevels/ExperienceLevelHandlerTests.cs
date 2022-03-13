using FluentAssertions;
using JobsCatalog.Application.Features.Dictionaries.Queries.ExperienceLevels;
using JobsCatalog.Persistance.Context;
using JobsCatalog.UnitTests.Common.TestBases;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace JobsCatalog.UnitTests.Features.Dictionaries.Queries.ExperienceLevels
{
    [Collection("QueryCollection")]
    public class ExperienceLevelHandlerTests
    {
        private readonly JobsCatalogDbContextTransaction _context;

        public ExperienceLevelHandlerTests(QueryTestBase testBase)
        {
            _context = testBase.ContextTransaction;
        }

        [Fact]
        public async Task ShouldReturnList()
        {
            var handler = new ExperienceLevelQueryHandler(_context);
            var result = await handler.Handle(new ExperienceLevelQuery(), CancellationToken.None);
            result.Should().HaveCount(4);
            result.Should().BeOfType<List<ExperienceLevelVm>>();
            result.ForEach(x =>
            {
                x.Id.Should().BeGreaterThan(0);
                x.Name.Should().NotBeNullOrWhiteSpace();
            });
        }
    }
}