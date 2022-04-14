using AutoMapper;
using FluentAssertions;
using JobsCatalog.Application.Features.Entities.Commands.AddJobOffer;
using JobsCatalog.Persistance.Context;
using JobsCatalog.UnitTests.Common.TestBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace JobsCatalog.UnitTests.Features.Entities.Commands.AddJobOffer
{
    [Collection("CommandCollection")]
    public class AddJobOfferCommandHandlerTests
    {
        private readonly JobsCatalogDbContext _context;
        private readonly IMapper _mapper;

        public AddJobOfferCommandHandlerTests(CommandTestBase testBase)
        {
            _context = testBase.Context;
            _mapper = testBase.Mapper;
        }

        [Fact]
        public async Task ShouldAddJob()
        {
            var positionName = "test";
            var salaryMin = 3000;
            var salaryMax = 6000;
            var city = "city test";
            var handler = new AddJobOfferCommandHandler(_context, _mapper);

            var result = await handler.Handle(
                new AddJobOfferCommand
                {
                    Model = new AddJobOfferDto
                    {
                        PositionName = positionName,
                        SalaryMin = salaryMin,
                        SalaryMax = salaryMax,
                        City = city,
                        ExperienceLevelId = 3,
                        CompanyId = 2,
                        ProgrammingLanguageId = 4
                    }
                },
                CancellationToken.None);

            var jobOffer = _context.JobOffers
                    .SingleOrDefault(x => x.Id == result);
            var jobDesc = _context.JobDescriptions
                    .SingleOrDefault(x => x.JobOfferId == result);

            result.Should().NotBeNull();
            jobOffer.PositionName.Should().Be(positionName);
            jobOffer.SalaryMin.Should().Be(salaryMin);
            jobOffer.SalaryMax.Should().Be(salaryMax);
            jobOffer.City.Should().Be(city);
            jobOffer.ExperienceLevelId.Should().Be(3);
            jobOffer.CompanyId.Should().Be(2);
            jobOffer.ProgrammingLanguageId.Should().Be(4);
            jobDesc.Should().BeNull();
        }
    }
}
