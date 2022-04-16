using JobsCatalog.API;
using JobsCatalog.Application.Features.Dictionaries.Queries.Technologies;
using JobsCatalog.IntegrationTests.Common;
using JobsCatalog.IntegrationTests.Configuration;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace JobsCatalog.IntegrationTests.Controller.Dictionary
{
    public class GetTechnologiesTests : IClassFixture<MyWebApplicationFactory<Startup>>
    {
        private readonly MyWebApplicationFactory<Startup> _factory;

        public GetTechnologiesTests(MyWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task GetTechnologies()
        {
            var client = await _factory.GetAuthenticatedClientAsync();

            var response = await client.GetAsync($"api/dictionaries/technologies");

            response.EnsureSuccessStatusCode();
            var vm = await Utilities.GetResponseContent<List<TechnologyVm>>(response);
            vm.ShouldBeOfType<List<TechnologyVm>>();
            vm.Count.ShouldBe(19);
        }
    }
}