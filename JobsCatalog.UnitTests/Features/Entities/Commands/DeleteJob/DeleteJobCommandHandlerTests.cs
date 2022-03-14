using FluentAssertions;
using JobsCatalog.Application.Features.Entities.Commands.DeleteJob;
using JobsCatalog.Persistance.Context;
using JobsCatalog.UnitTests.Common.TestBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace JobsCatalog.UnitTests.Features.Entities.Commands.DeleteJob
{
    [Collection("CommandCollection")]
    public class DeleteJobCommandHandlerTests
    {
        private readonly JobsCatalogDbContext _context;

        public DeleteJobCommandHandlerTests(CommandTestBase testBase)
        {
            _context = testBase.Context;
        }

        [Fact]
        public async Task ShouldDeleteTechnologies()
        {
            var jobOfferBeforeDelete = _context.JobOffers.SingleOrDefault(x => x.Id == 1);
            var jobDescriptionsBeforeDelete = _context.JobDescriptions.SingleOrDefault(x => x.JobOfferId == 1);

            var technologies = new List<int> { 2, 1 };
            var handler = new DeleteJobCommandHandler(_context);
            var result = await handler.Handle(
                new DeleteJobCommand
                {
                    Id = 1,
                },
                CancellationToken.None);

            var jobOfferAfterDelete = _context.JobOffers.SingleOrDefault(x => x.Id == 1);
            var jobDescriptionsAfterDelete = _context.JobDescriptions.SingleOrDefault(x => x.JobOfferId == 1);

            result.Should().BeGreaterThan(0);
            jobOfferAfterDelete.PositionName.Should().Be(jobOfferBeforeDelete.PositionName);
            jobOfferAfterDelete.SalaryMin.Should().Be(jobOfferBeforeDelete.SalaryMin);
            jobOfferAfterDelete.SalaryMax.Should().Be(jobOfferBeforeDelete.SalaryMax);
            jobOfferAfterDelete.City.Should().Be(jobOfferBeforeDelete.City);
            jobOfferAfterDelete.ExperienceLevelId.Should().Be(jobOfferBeforeDelete.ExperienceLevelId);
            jobOfferAfterDelete.CompanyId.Should().Be(jobOfferBeforeDelete.CompanyId);
            jobOfferAfterDelete.ProgrammingLanguageId.Should().Be(jobOfferBeforeDelete.ProgrammingLanguageId);
            jobOfferAfterDelete.City.Should().Be(jobOfferBeforeDelete.City);
            jobOfferAfterDelete.StatusId.Should().Be(0);

            jobDescriptionsAfterDelete.About.Should().Be(jobDescriptionsBeforeDelete.About);
            jobDescriptionsAfterDelete.Expectation.Should().Be(jobDescriptionsBeforeDelete.Expectation);
            jobDescriptionsAfterDelete.Responsibilities.Should().Be(jobDescriptionsBeforeDelete.Responsibilities);
            jobDescriptionsAfterDelete.Offer.Should().Be(jobDescriptionsBeforeDelete.Offer);
            jobDescriptionsAfterDelete.StatusId.Should().Be(0);
        }
    }
}
