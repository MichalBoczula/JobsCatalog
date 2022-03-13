using AutoMapper;
using FluentAssertions;
using JobsCatalog.Application.Features.Entities.Commands.UpdateJob;
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

namespace JobsCatalog.UnitTests.Features.Entities.Commands.UpdateJob
{
    [Collection("CommandCollection")]
    public class UpdateJobCommandHandlerTests
    {
        private readonly JobsCatalogDbContextTransaction _context;
        private readonly IMapper _mapper;

        public UpdateJobCommandHandlerTests(CommandTestBase testBase)
        {
            _context = testBase.ContextTransaction;
            _mapper = testBase.Mapper;
        }

        [Fact]
        public async Task ShouldUpdateJob()
        {
            var handler = new UpdateJobCommandHandler(_context, _mapper);
            var result = await handler.Handle(
                new UpdateJobCommand
                {
                    Id = 1,
                    Model = new UpdateJobVm
                    {
                        PositionName = "Junior .Net Developer",
                        SalaryMin = 6000,
                        SalaryMax = 9000,
                        City = "Wroclaw test",
                        ExperienceLevelId = 1,
                        CompanyId = 1,
                        ProgrammingLanguageId = 1,
                    }
                },
                CancellationToken.None);

            result.Should().Be(1);
            var jobAfterUpdate = _context.JobOffers
                .SingleOrDefault(x => x.Id == 1);
            jobAfterUpdate.PositionName.Should().Be("Junior .Net Developer");
            jobAfterUpdate.SalaryMin.Should().Be(6000);
            jobAfterUpdate.SalaryMax.Should().Be(9000);
            jobAfterUpdate.City.Should().Be("Wroclaw test");
            jobAfterUpdate.ExperienceLevelId.Should().Be(1);
            jobAfterUpdate.CompanyId.Should().Be(1);
            jobAfterUpdate.ProgrammingLanguageId.Should().Be(1);
        }
    }
}
