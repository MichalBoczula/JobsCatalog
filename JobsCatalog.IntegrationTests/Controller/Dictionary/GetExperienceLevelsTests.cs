using JobsCatalog.API;
using JobsCatalog.Application.Features.Dictionaries.Queries.ExperienceLevels;
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
    public class GetExperienceLevelsTests : IClassFixture<MyWebApplicationFactory<Startup>>
    {
        private readonly MyWebApplicationFactory<Startup> _factory;

        public GetExperienceLevelsTests(MyWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task GetExperienceLevels()
        {
            var client = await _factory.GetAuthenticatedClientAsync();

            var response = await client.GetAsync($"api/dictionaries/experienceLevels");
            response.EnsureSuccessStatusCode();

            var vm = await Utilities.GetResponseContent<List<ExperienceLevelVm>>(response);
            vm.Count.ShouldBe(4);
        }
    }
}