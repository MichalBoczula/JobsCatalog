using JobsCatalog.API;
using JobsCatalog.Application.Features.Entities.Queries.JobDetails;
using JobsCatalog.IntegrationTests.Common;
using JobsCatalog.IntegrationTests.Configuration;
using Microsoft.AspNetCore.Mvc;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace JobsCatalog.IntegrationTests.Controller.JobsCatalog.Queries
{
    public class GetDetailsTests : IClassFixture<MyWebApplicationFactory<Startup>>
    {
        private readonly MyWebApplicationFactory<Startup> _factory;

        public GetDetailsTests(MyWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task GetJobDetails()
        {
            //arrange
            var client = await _factory.GetAuthenticatedClientAsync();

            //act
            var response = await client.GetAsync($"api/jobs/1");
            
            //assert
            response.EnsureSuccessStatusCode();
            var vm = await Utilities.GetResponseContent<JobDetailsVm>(response);
            vm.ShouldBeOfType<JobDetailsVm>();
        }

        [Fact]
        public async Task GetJobDetails_JobDoesntExist()
        {
            //arrange
            var client = await _factory.GetAuthenticatedClientAsync();

            //act
            var response = await client.GetAsync($"api/jobs/1111");

            //assert
            var vm = await Utilities.GetResponseContent<NotFoundResult>(response);
            vm.StatusCode.ShouldBe(404);
        }
    }
}