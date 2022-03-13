using FluentAssertions;
using JobsCatalog.Application.Features.Dictionaries.Queries.ProgrammingLanguages;
using JobsCatalog.Persistance.Context;
using JobsCatalog.UnitTests.Common.TestBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace JobsCatalog.UnitTests.Features.Dictionaries.Queries.ProgrammingLanguages
{
    [Collection("QueryCollection")]
    public class ProgrammingLanguageHandlerTests
    {
        private readonly JobsCatalogDbContextTransaction _context;

        public ProgrammingLanguageHandlerTests(QueryTestBase testBase)
        {
            _context = testBase.ContextTransaction;
        }

        [Fact]
        public async Task ShouldReturnList()
        {
            var handler = new ProgrammingLanguageQueryHandler(_context);
            var result = await handler.Handle(new ProgrammingLanguageQuery(), CancellationToken.None);
            result.Should().HaveCount(5);
            result.Should().BeOfType<List<ProgrammingLanguageVm>>();
            result.ForEach(x =>
            {
                x.Id.Should().BeGreaterThan(0);
                x.Name.Should().NotBeNullOrWhiteSpace();
                x.Image.Should().NotBeNullOrWhiteSpace();
            });
        }
    }
}
