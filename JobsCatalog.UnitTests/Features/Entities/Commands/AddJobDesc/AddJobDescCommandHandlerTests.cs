using AutoMapper;
using FluentAssertions;
using JobsCatalog.Application.Features.Entities.Commands.AddJobDesc;
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

namespace JobsCatalog.UnitTests.Features.Entities.Commands.AddJobDesc
{
    [Collection("CommandCollection")]
    public class AddJobDescCommandHandlerTests
    {
        private readonly JobsCatalogDbContext _context;
        private readonly IMapper _mapper;

        public AddJobDescCommandHandlerTests(CommandTestBase testBase)
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
            var about = "about";
            var expectation = "expectation";
            var responsibilities = "responsibilities";
            var offer = "offer";
            var jobHandler = new AddJobOfferCommandHandler(_context, _mapper);
            var jobDescHandler = new AddJobDescCommandHandler(_context, _mapper);

            var jobId = await jobHandler.Handle(
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

            var result = await jobDescHandler.Handle(
               new AddJobDescCommand
               {
                   JobOfferId = (int)jobId,
                   Model = new AddJobDescDto
                   {
                       About = about,
                       Expectation = expectation,
                       Responsibilities = responsibilities,
                       Offer = offer
                   }
               },
               CancellationToken.None);

            var jobOffer = _context.JobOffers
                    .SingleOrDefault(x => x.Id == jobId);
            var jobDesc = _context.JobDescriptions
                    .SingleOrDefault(x => x.JobOfferId == jobId);

            jobOffer.PositionName.Should().Be(positionName);
            jobOffer.SalaryMin.Should().Be(salaryMin);
            jobOffer.SalaryMax.Should().Be(salaryMax);
            jobOffer.City.Should().Be(city);
            jobOffer.ExperienceLevelId.Should().Be(3);
            jobOffer.CompanyId.Should().Be(2);
            jobOffer.ProgrammingLanguageId.Should().Be(4);
            
            result.Should().NotBeNull();
            jobDesc.About.Should().Be(about);
            jobDesc.Expectation.Should().Be(expectation);
            jobDesc.Responsibilities.Should().Be(responsibilities);
            jobDesc.Offer.Should().Be(offer);
        }
    }
}
