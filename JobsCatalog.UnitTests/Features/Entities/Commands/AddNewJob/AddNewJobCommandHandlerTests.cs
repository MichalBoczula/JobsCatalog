using AutoMapper;
using FluentAssertions;
using JobsCatalog.Application.Features.Entities.Commands.AddNewJobWholeObj;
using JobsCatalog.Persistance.Context;
using JobsCatalog.UnitTests.Common;
using JobsCatalog.UnitTests.Common.TestBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace JobsCatalog.UnitTests.Features.Entities.Commands.AddNewJob
{
    [Collection("CommandCollection")]
    public class AddNewJobCommandHandlerTests
    {
        private readonly JobsCatalogDbContext _context;
        private readonly IMapper _mapper;

        public AddNewJobCommandHandlerTests(CommandTestBase testBase)
        {
            _context = testBase.Context;
            _mapper = testBase.Mapper;
        }

        [Fact]
        public async Task ShouldAddJob()
        {
            var handler = new AddNewJobCommandHandler(_context, _mapper);
            var testTechnologies = new List<int>() { 1, 2, 3 };
            var result = await handler.Handle(
                new AddNewJobCommand
                {
                    Model = new AddNewJobVm
                    {
                        JobOffer = new AddJob_JobOfferDto
                        {
                            PositionName = "test",
                            SalaryMin = 2800,
                            SalaryMax = 5000,
                            City = "test",
                            ExperienceLevelId = 1,
                            CompanyId = 1,
                            ProgrammingLanguageId = 1
                        },
                        JobDescritpion = new AddJob_JobDescritpionDto
                        {
                            About = "dsaaaaaaaaaadsd",
                            Responsibilities = "dsaaaaaaaaaadsd",
                            Expectation = "dsaaaaaaaaaadsd",
                            Offer = "dsaaaaaaaaaadsd"
                        },
                        Technologies = testTechnologies
                    }
                },
                CancellationToken.None);

            var resultDesc = _context.JobDescriptions
                .SingleOrDefault(x => x.JobOfferId == result);
            var job = _context.JobOffers
                .SingleOrDefault(x => x.Id == result);
            var technologies = _context.JobOfferTechnologies
                .Where(x => x.JobOfferId == result).ToList();

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
