using JobsCatalog.API;
using JobsCatalog.IntegrationTests.Configuration;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Xunit;

namespace JobsCatalog.IntegrationTests.Controller.JobsCatalog.Command
{
    public class AddTechnology : IClassFixture<MyWebApplicationFactory<Startup>>
    {
        private readonly MyWebApplicationFactory<Startup> _factory;

        public AddTechnology(MyWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task AddNewTechnology_Added()
        {
            //arrange
            var client = await _factory.GetAuthenticatedClientAsync();
            var list = new List<int> { 4 };

            //act
            var response = await client.PostAsJsonAsync($"api/jobs/1/technologies/add", list);

            //assert
            response.StatusCode.ShouldBe(System.Net.HttpStatusCode.NoContent);
            response.IsSuccessStatusCode.ShouldBeTrue();
        }

        [Fact]
        public async Task AddNewTechnology_False_JobOfferDoesNOTExist()
        {
            //arrange
            var client = await _factory.GetAuthenticatedClientAsync();
            var list = new List<int> { 4 };

            //act
            var response = await client.PostAsJsonAsync($"api/jobs/1111/technologies/add", list).ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            response.Errors.Count().ShouldBe(1);
            var error = response.Errors.First();
            error.PropertyName.ShouldBe("JobOfferId");
            error.ErrorMessage.ShouldBe("JobOffer with id: 1111 does not exist in db");
        }

        [Fact]
        public async Task AddNewTechnology_False_TechnologiesIdLesserThanZero()
        {
            //arrange
            var client = await _factory.GetAuthenticatedClientAsync();
            var list = new List<int> { -4 };

            //act
            var response = await client.PostAsJsonAsync($"api/jobs/1/technologies/add", list).ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            response.Errors.Count().ShouldBe(1);
            var error = response.Errors.First();
            error.PropertyName.ShouldBe("Technologies");
            error.ErrorMessage.ShouldBe("Technology id must be greater then 0, error caused by -4 value");
        }

        [Fact]
        public async Task AddNewTechnology_False_TechnologiesAddedMultipleTimes()
        {
            //arrange
            var client = await _factory.GetAuthenticatedClientAsync();
            var list = new List<int> { 5, 5, 5 };

            //act
            var response = await client.PostAsJsonAsync($"api/jobs/1/technologies/add", list).ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            response.Errors.Count().ShouldBe(1);
            var error = response.Errors.First();
            error.PropertyName.ShouldBe("Technologies");
            error.ErrorMessage.ShouldBe("Technology id 5 has been added to request 3 times, input unique value");
        }

        [Fact]
        public async Task AddNewTechnology_False_TechnologyHasAlredyExisted()
        {
            //arrange
            var client = await _factory.GetAuthenticatedClientAsync();
            var list = new List<int> { 2 };

            //act
            var response = await client.PostAsJsonAsync($"api/jobs/1/technologies/add", list).ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            response.Errors.Count().ShouldBe(1);
            var error = response.Errors.First();
            error.ErrorMessage.ShouldBe("Technology with id 2 has been already added to job identify by 1");
        }
    }
}
