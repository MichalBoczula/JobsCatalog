using JobsCatalog.API;
using JobsCatalog.Application.Features.Entities.Queries.JobsList;
using JobsCatalog.IntegrationTests.Common;
using JobsCatalog.IntegrationTests.Configuration;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace JobsCatalog.IntegrationTests.Controller.JobsCatalog.Queries
{
    public class GetListTests : IClassFixture<MyWebApplicationFactory<Startup>>
    {
        private readonly MyWebApplicationFactory<Startup> _factory;

        public GetListTests(MyWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task GetJobList()
        {
            //arrange
            var client = await _factory.GetAuthenticatedClientAsync();

            //act
            var response = await client.GetAsync($"api/jobs");

            //assert
            response.EnsureSuccessStatusCode();
            var vm = await Utilities.GetResponseContent<List<JobsListVm>>(response);
            vm.Count.ShouldBe(15);
        }
    }
}