using AutoMapper;
using FluentAssertions;
using JobsCatalog.Application.Features.Entities.Commands.AddTechnology;
using JobsCatalog.Persistance.Context;
using JobsCatalog.UnitTests.Common.TestBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace JobsCatalog.UnitTests.Features.Entities.Commands.AddTechnology
{
    [Collection("CommandCollection")]
    public class AddTechnologyCommandHandlerTests
    {
        private readonly JobsCatalogDbContextTransaction _context;

        public AddTechnologyCommandHandlerTests(CommandTestBase testBase)
        {
            _context = testBase.ContextTransaction;
        }

        [Fact]
        public async Task ShouldUpdateJob()
        {
            var technologiesBeforeUpdate = _context.JobOfferTechnologies
                .Where(x => x.JobOfferId == 1).Select(x => x.TechnologyId).ToList();
            var technologies = new List<int> { 4, 5, 6 };
            var handler = new AddTechnologyCommandHandler(_context);
            var result = await handler.Handle(
                new AddTechnologyCommand
                {
                    JobOfferId= 1,
                    Technologies = technologies
                },
                CancellationToken.None);

            var technologiesAfterUpdate = _context.JobOfferTechnologies
                .Where(x => x.JobOfferId == 1).Select(x => x.TechnologyId).ToList();

            result.Should().BeOfType<List<int>>();
            technologiesAfterUpdate.Should()
                .HaveCount(technologiesBeforeUpdate.Concat<int>(technologies).Count());
            result.ForEach(x =>
            {
                technologiesAfterUpdate.Contains(x).Should().BeTrue();
            });
            technologies.ForEach(x =>
            {
                technologiesAfterUpdate.Contains(x).Should().BeTrue();
            });
        }
    }
}
