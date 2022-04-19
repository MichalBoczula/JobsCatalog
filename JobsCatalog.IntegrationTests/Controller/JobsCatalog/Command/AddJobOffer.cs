using JobsCatalog.API;
using JobsCatalog.Application.Features.Entities.Commands.AddJobOffer;
using JobsCatalog.Application.Features.Entities.Queries.JobDetails;
using JobsCatalog.IntegrationTests.Common;
using JobsCatalog.IntegrationTests.Configuration;
using Microsoft.AspNetCore.Mvc;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Xunit;

namespace JobsCatalog.IntegrationTests.Controller.JobsCatalog.Command
{
    [Collection("AddJob")]
    public class AddJobOffer : IClassFixture<MyWebApplicationFactory<Startup>>
    {
        private readonly MyWebApplicationFactory<Startup> _factory;

        public AddJobOffer(MyWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task AddNeewJobOffer_JabAdded()
        {
            //arrange
            var positionName = "test";
            var salaryMin = 3000;
            var salaryMax = 6000;
            var city = "city test";
            var client = await _factory.GetAuthenticatedClientAsync();
            var obj = new AddJobOfferDto
            {
                PositionName = positionName,
                SalaryMin = salaryMin,
                SalaryMax = salaryMax,
                City = city,
                ExperienceLevelId = 3,
                CompanyId = 2,
                ProgrammingLanguageId = 4
            };

            //act
            var response = await client.PostAsJsonAsync($"api/jobs/addJobOffer", obj);
            
            //assert
            var vm = await Utilities.GetResponseContent<CreatedAtActionResult>(response);
            var returnValue = await response.Content.ReadAsStringAsync();
            vm.StatusCode.ShouldBe(201);
            returnValue.ShouldBe("{\"id\":16}");
        }
    }
}