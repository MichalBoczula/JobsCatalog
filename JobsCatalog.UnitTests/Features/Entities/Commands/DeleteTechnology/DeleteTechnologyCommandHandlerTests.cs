//using FluentAssertions;
//using JobsCatalog.Application.Features.Entities.Commands.DeleteTechnology;
//using JobsCatalog.Persistance.Context;
//using JobsCatalog.UnitTests.Common.TestBases;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
//using Xunit;

//namespace JobsCatalog.UnitTests.Features.Entities.Commands.DeleteTechnology
//{
//    [Collection("CommandCollection")]
//    public class DeleteTechnologyCommandHandlerTests
//    {
//        private readonly JobsCatalogDbContextTransaction _context;

//        public DeleteTechnologyCommandHandlerTests(CommandTestBase testBase)
//        {
//            _context = testBase.ContextTransaction;
//        }

//        [Fact]
//        public async Task ShouldDeleteTechnologies()
//        {
//            var technologiesBeforeUpdate = _context.JobOfferTechnologies
//                .Where(x => x.JobOfferId == 1).Select(x => x.TechnologyId).ToList();
//            var technologies = new List<int> { 2, 1 };
//            var handler = new DeleteTechnologyCommandHandler(_context);
//            var result = await handler.Handle(
//                new DeleteTechnologyCommand
//                {
//                    JobOfferId = 1,
//                    Technologies = technologies
//                },
//                CancellationToken.None);

//            var technologiesAfterUpdate = _context.JobOfferTechnologies
//                .Where(x => x.JobOfferId == 1).Select(x => x.TechnologyId).ToList();

//            result.Should().Be(2);
//            technologiesAfterUpdate.Should().HaveCount(1);
//            technologiesAfterUpdate[0].Should().Be(3);
//        }

//        [Fact]
//        public async Task ShouldUpdateJob()
//        {
//            var technologiesBeforeUpdate = _context.JobOfferTechnologies
//                .Where(x => x.JobOfferId == 1).Select(x => x.TechnologyId).ToList();
//            var technologies = new List<int> { 2, 2, 5 };
//            var handler = new DeleteTechnologyCommandHandler(_context);
//            var result = await handler.Handle(
//                new DeleteTechnologyCommand
//                {
//                    JobOfferId = 1,
//                    Technologies = technologies
//                },
//                CancellationToken.None);

//            var technologiesAfterUpdate = _context.JobOfferTechnologies
//                .Where(x => x.JobOfferId == 1).Select(x => x.TechnologyId).ToList();

//            result.Should().Be(1);
//            technologiesAfterUpdate.Should().HaveCount(2);
//            technologiesAfterUpdate[0].Should().Be(1);
//            technologiesAfterUpdate[1].Should().Be(3);
//        }
//    }
//}
