using FluentAssertions;
using JobsCatalog.Application.Features.Dictionaries.Queries.Technologies;
using JobsCatalog.Persistance.Context;
using JobsCatalog.UnitTests.Common.TestBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace JobsCatalog.UnitTests.Features.Dictionaries.Queries.Technologies
{
    [Collection("QueryCollection")]
    public class TechnologyQueryHandlerTests
    {
        private readonly JobsCatalogDbContext _context;

        public TechnologyQueryHandlerTests(QueryTestBase testBase)
        {
            _context = testBase.Context;
        }

        [Fact]
        public async Task ShouldReturnList()
        {
            var handler = new TechnologyQueryHandler(_context);
            var result = await handler.Handle(new TechnologyQuery(), CancellationToken.None);
            result.Should().HaveCount(19);
            result.Should().BeOfType<List<TechnologyVm>>();
            result.ForEach(x =>
            {
                x.Id.Should().BeGreaterThan(0);
                x.Name.Should().NotBeNullOrWhiteSpace();
            });
        }
    }
}
