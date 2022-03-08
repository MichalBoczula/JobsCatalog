using FluentAssertions;
using JobsCatalog.Persistance.Context;
using JobsCatalog.Test.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace JobsCatalog.Application.Features.Additional.Queries.AveragePayment
{
    [Collection("QueryCollection")]
    public class AveragePaymentQueryHandlerTests
    {
        private readonly JobsCatalogDbContext _context;

        public AveragePaymentQueryHandlerTests(QueryTestBase testBase)
        {
            _context = testBase.Context;
        }

        [Fact]
        public async Task ShouldReturnAllStats()
        {
            //arrange
            var handler = new AveragePaymentQueryHandler(_context);
            //act
            var result = await handler.Handle(
                new AveragePaymentQuery() { ExperienceLevelName = "aLL" },
                CancellationToken.None);
            //assert
            result.Should().BeOfType<AveragePaymentVm>();
            result.ExperienceLevelSalariesDtos.Count.Should().Be(4);
            result.ExperienceLevelSalariesDtos[0].ExperienceLevel.Should().Be("Junior");
            result.ExperienceLevelSalariesDtos[0].AvgMinSalary.Should().Be(6000);
            result.ExperienceLevelSalariesDtos[0].AvgMaxSalary.Should().Be(8000);
            result.ExperienceLevelSalariesDtos[1].ExperienceLevel.Should().Be("Mid");
            result.ExperienceLevelSalariesDtos[1].AvgMinSalary.Should().Be(10000);
            result.ExperienceLevelSalariesDtos[1].AvgMaxSalary.Should().Be(15000);
            result.ExperienceLevelSalariesDtos[2].ExperienceLevel.Should().Be("Senior");
            result.ExperienceLevelSalariesDtos[2].AvgMinSalary.Should().Be(15000);
            result.ExperienceLevelSalariesDtos[2].AvgMaxSalary.Should().Be(20000);
            result.ExperienceLevelSalariesDtos[3].ExperienceLevel.Should().Be("Expert");
            result.ExperienceLevelSalariesDtos[3].AvgMinSalary.Should().Be(20000);
            result.ExperienceLevelSalariesDtos[3].AvgMaxSalary.Should().Be(30000);
        }

        [Fact]
        public async Task ShouldReturnJuniorStats()
        {
            //arrange
            var handler = new AveragePaymentQueryHandler(_context);
            //act
            var result = await handler.Handle(
                new AveragePaymentQuery() { ExperienceLevelName = "JuNIOr" },
                CancellationToken.None);
            //assert
            result.ExperienceLevelSalariesDtos[0].ExperienceLevel.Should().Be("Junior");
            result.ExperienceLevelSalariesDtos[0].AvgMinSalary.Should().Be(6000);
            result.ExperienceLevelSalariesDtos[0].AvgMaxSalary.Should().Be(8000);
        }

        [Fact]
        public async Task ShouldReturnMidStats()
        {
            //arrange
            var handler = new AveragePaymentQueryHandler(_context);
            //act
            var result = await handler.Handle(
                new AveragePaymentQuery() { ExperienceLevelName = "miD  " },
                CancellationToken.None);
            //assert
            result.ExperienceLevelSalariesDtos[0].ExperienceLevel.Should().Be("Mid");
            result.ExperienceLevelSalariesDtos[0].AvgMinSalary.Should().Be(10000);
            result.ExperienceLevelSalariesDtos[0].AvgMaxSalary.Should().Be(15000);
        }

        [Fact]
        public async Task ShouldReturnSeniorStats()
        {
            //arrange
            var handler = new AveragePaymentQueryHandler(_context);
            //act
            var result = await handler.Handle(
                new AveragePaymentQuery() { ExperienceLevelName = "  seNioR  " },
                CancellationToken.None);
            //assert
            result.Should().BeOfType<AveragePaymentVm>();
            result.ExperienceLevelSalariesDtos.Count.Should().Be(1);
            result.ExperienceLevelSalariesDtos[0].ExperienceLevel.Should().Be("Senior");
            result.ExperienceLevelSalariesDtos[0].AvgMinSalary.Should().Be(15000);
            result.ExperienceLevelSalariesDtos[0].AvgMaxSalary.Should().Be(20000);
        }

        [Fact]
        public async Task ShouldReturnExpertStats()
        {
            //arrange
            var handler = new AveragePaymentQueryHandler(_context);
            //act
            var result = await handler.Handle(
                new AveragePaymentQuery() { ExperienceLevelName = " ExPErt  " },
                CancellationToken.None);
            //assert
            result.Should().BeOfType<AveragePaymentVm>();
            result.ExperienceLevelSalariesDtos.Count.Should().Be(1);
            result.ExperienceLevelSalariesDtos[0].ExperienceLevel.Should().Be("Expert");
            result.ExperienceLevelSalariesDtos[0].AvgMinSalary.Should().Be(20000);
            result.ExperienceLevelSalariesDtos[0].AvgMaxSalary.Should().Be(30000);
        }

        [Fact]
        public async Task ShouldBeEmpty()
        {
            //arrange
            var handler = new AveragePaymentQueryHandler(_context);
            //act
            var result = await handler.Handle(
               new AveragePaymentQuery() { ExperienceLevelName = " empty  " },
               CancellationToken.None);
            //assert
            result.Should().BeOfType<AveragePaymentVm>();
            result.ExperienceLevelSalariesDtos.Should().BeEmpty();
        }
    }
}
