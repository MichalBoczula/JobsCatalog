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

namespace JobsCatalog.IntegrationTests.Controller.StatisticsController
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
            var client = await _factory.GetAuthenticatedClientAsync();

            var response = await client.GetAsync($"api/stats?experienceLevel=all");
            response.EnsureSuccessStatusCode();
            
            var vm = await Utilities.GetResponseContent<AveragePaymentVm>(response);
            vm.ShouldNotBeNull();
            vm.ExperienceLevelSalariesDtos.Count.ShouldBe(4);
        }

        [Fact]
        public async Task GetJuniorStats()
        {
            var client = await _factory.GetAuthenticatedClientAsync();

            var response = await client.GetAsync($"api/stats?experienceLevel=junior");
            response.EnsureSuccessStatusCode();

            var vm = await Utilities.GetResponseContent<AveragePaymentVm>(response);
            vm.ShouldNotBeNull();
            vm.ExperienceLevelSalariesDtos.Count.ShouldBe(1);
        }

        [Fact]
        public async Task GetMidStats()
        {
            var client = await _factory.GetAuthenticatedClientAsync();

            var response = await client.GetAsync($"api/stats?experienceLevel=mid");
            response.EnsureSuccessStatusCode();

            var vm = await Utilities.GetResponseContent<AveragePaymentVm>(response);
            vm.ShouldNotBeNull();
            vm.ExperienceLevelSalariesDtos.Count.ShouldBe(1);
        }

        [Fact]
        public async Task GetSeniorStats()
        {
            var client = await _factory.GetAuthenticatedClientAsync();

            var response = await client.GetAsync($"api/stats?experienceLevel=senior");
            response.EnsureSuccessStatusCode();

            var vm = await Utilities.GetResponseContent<AveragePaymentVm>(response);
            vm.ShouldNotBeNull();
            vm.ExperienceLevelSalariesDtos.Count.ShouldBe(1);
        }

        [Fact]
        public async Task GetExpertStats()
        {
            var client = await _factory.GetAuthenticatedClientAsync();

            var response = await client.GetAsync($"api/stats?experienceLevel=expert");
            response.EnsureSuccessStatusCode();

            var vm = await Utilities.GetResponseContent<AveragePaymentVm>(response);
            vm.ShouldNotBeNull();
        }

        [Fact]
        public async Task GetStatsWrongParam()
        {
            var client = await _factory.GetAuthenticatedClientAsync();

            var response = await client.GetAsync($"api/stats?experienceLevel=test");

            var vm = await Utilities.GetResponseContent<AveragePaymentVm>(response);
            vm.ExperienceLevelSalariesDtos.ShouldBeNull();
        }
    }
}