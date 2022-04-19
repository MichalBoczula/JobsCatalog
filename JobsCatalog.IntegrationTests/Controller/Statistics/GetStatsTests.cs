using JobsCatalog.API;
using JobsCatalog.Application.Features.Additional.Queries.AveragePayment;
using JobsCatalog.IntegrationTests.Common;
using JobsCatalog.IntegrationTests.Configuration;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace JobsCatalog.IntegrationTests.Controller.Statistics
{
    public class GetStatsTests : IClassFixture<MyWebApplicationFactory<Startup>>
    {
        private readonly MyWebApplicationFactory<Startup> _factory;

        public GetStatsTests(MyWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task GetAllStats()
        {
            //arrange
            var client = await _factory.GetAuthenticatedClientAsync();

            //act
            var response = await client.GetAsync($"api/stats?experienceLevel=all");

            //assert
            response.EnsureSuccessStatusCode();
            var vm = await Utilities.GetResponseContent<AveragePaymentVm>(response);
            vm.ShouldNotBeNull();
            vm.ExperienceLevelSalariesDtos.Count.ShouldBe(4);
        }

        [Fact]
        public async Task GetJuniorStats()
        {
            //arrange
            var client = await _factory.GetAuthenticatedClientAsync();

            //act
            var response = await client.GetAsync($"api/stats?experienceLevel=junior");
            
            //assert
            response.EnsureSuccessStatusCode();
            var vm = await Utilities.GetResponseContent<AveragePaymentVm>(response);
            vm.ShouldNotBeNull();
            vm.ExperienceLevelSalariesDtos.Count.ShouldBe(1);
        }

        [Fact]
        public async Task GetMidStats()
        {
            //arrange
            var client = await _factory.GetAuthenticatedClientAsync();

            //act
            var response = await client.GetAsync($"api/stats?experienceLevel=mid");
            response.EnsureSuccessStatusCode();

            //assert
            var vm = await Utilities.GetResponseContent<AveragePaymentVm>(response);
            vm.ShouldNotBeNull();
            vm.ExperienceLevelSalariesDtos.Count.ShouldBe(1);
        }

        [Fact]
        public async Task GetSeniorStats()
        {
            //arrange
            var client = await _factory.GetAuthenticatedClientAsync();

            //act
            var response = await client.GetAsync($"api/stats?experienceLevel=senior");
            response.EnsureSuccessStatusCode();

            //assert
            var vm = await Utilities.GetResponseContent<AveragePaymentVm>(response);
            vm.ShouldNotBeNull();
            vm.ExperienceLevelSalariesDtos.Count.ShouldBe(1);
        }

        [Fact]
        public async Task GetExpertStats()
        {
            //arrange
            var client = await _factory.GetAuthenticatedClientAsync();

            //act
            var response = await client.GetAsync($"api/stats?experienceLevel=expert");
            
            //assert
            response.EnsureSuccessStatusCode();
            var vm = await Utilities.GetResponseContent<AveragePaymentVm>(response);
            vm.ShouldNotBeNull();
        }

        [Fact]
        public async Task GetStatsWrongParam()
        {
            //arrange
            var client = await _factory.GetAuthenticatedClientAsync();
            
            //act
            var response = await client.GetAsync($"api/stats?experienceLevel=test");

            //assert
            var vm = await Utilities.GetResponseContent<AveragePaymentVm>(response);
            vm.ExperienceLevelSalariesDtos.ShouldBeNull();
        }
    }
}