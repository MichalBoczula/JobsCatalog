using FluentAssertions;
using JobsCatalog.Application.Features.Entities.Commands.AddNewJob;
using JobsCatalog.Persistance.Context;
using JobsCatalog.UnitTests.Common;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace JobsCatalog.UnitTests.Features.Entities.Commands.AddNewJob
{
    [Collection("CommandCollection")]
    public class AddNewJobCommandHandlerTests
    {
        private readonly JobsCatalogDbContext _context;

        public AddNewJobCommandHandlerTests(CommandTestBase testBase)
        {
            _context = testBase.Context;
        }

        [Fact]
        public async Task ShouldReturnNegativeOne()
        {
            var handler = new AddNewJobCommandHandler(_context);
            var testTechnologies = new List<int>() { 1, 2, 3 };
            var result = await handler.Handle(
                new AddNewJobCommand
                {
                    IsProductionMode = false,
                    Model = new AddNewJobVm
                    {
                        PositionName = "test",
                        SalaryMin = 2800,
                        SalaryMax = 5000,
                        City = "test",
                        ExperienceLevelId = 1,
                        CompanyId = 1,
                        ProgrammingLanguageId = 1,
                        About = "dsaaaaaaaaaadsd",
                        Responsibilities = "dsaaaaaaaaaadsd",
                        Expectation = "dsaaaaaaaaaadsd",
                        Offer = "dsaaaaaaaaaadsd",
                        Technologies = testTechnologies
                    }
                },
                CancellationToken.None);

            var resultDesc = _context.JobDescriptions.Where(x => x.JobOfferId == result).SingleOrDefault();
            var job = _context.JobOffers.Where(x => x.Id == result).SingleOrDefault();
            var technologies = _context.JobOfferTechnologies.Where(x => x.JobOfferId == result).ToList();

            result.Should().Be(16);
            _context.JobOffers.Count().Should().Be(16);
            resultDesc.About.Should().NotBeNullOrWhiteSpace();
            resultDesc.Responsibilities.Should().NotBeNullOrWhiteSpace();
            resultDesc.Expectation.Should().NotBeNullOrWhiteSpace();
            resultDesc.Offer.Should().NotBeNullOrWhiteSpace();
            technologies.Where(
                x => x.JobOfferId != result
                && testTechnologies.Contains(x.TechnologyId) == false)
                .ToList().Should().BeEmpty();
        }
    }
}
