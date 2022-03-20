using AutoMapper;
using FluentAssertions;
using JobsCatalog.Application.Features.Entities.Commands.UpdateJob;
using JobsCatalog.Application.Features.Entities.Commands.UpdateJobDescription;
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

namespace JobsCatalog.UnitTests.Features.Entities.Commands.UpdateJobDescription
{
    [Collection("CommandCollection3")]
    public class UpdateJobDescriptionCommandHandlerTests
    {
        private readonly JobsCatalogDbContext _context;

        public UpdateJobDescriptionCommandHandlerTests(CommandTestBase testBase)
        {
            _context = testBase.Context;
        }

        [Fact]
        public async Task ShouldUpdateJobDescription()
        {
            var handler = new UpdateJobDescriptionCommandHandler(_context);
            var result = await handler.Handle(
                new UpdateJobDescriptionCommand
                {
                    JobOfferId = 1,
                    Model = new UpdateJobDescriptionVm
                    {
                        About = "Lorem ipsum ...1",
                        Responsibilities = "Lorem ipsum ...2",
                        Offer = "Lorem ipsum ...3",
                        Expectation = "Lorem ipsum ...4"
                    }
                },
                CancellationToken.None);

            var jobDescAfterUpdate = _context.JobDescriptions
                .SingleOrDefault(x => x.JobOfferId == 1);

            result.Should().Be(1);
            jobDescAfterUpdate.About.Should().Be("Lorem ipsum ...1");
            jobDescAfterUpdate.Responsibilities.Should().Be("Lorem ipsum ...2");
            jobDescAfterUpdate.Offer.Should().Be("Lorem ipsum ...3");
            jobDescAfterUpdate.Expectation.Should().Be("Lorem ipsum ...4");
            jobDescAfterUpdate.JobOfferId.Should().Be(1);
        }
    }
}
