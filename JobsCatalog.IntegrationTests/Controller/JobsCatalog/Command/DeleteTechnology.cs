using JobsCatalog.API;
using JobsCatalog.IntegrationTests.Configuration;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace JobsCatalog.IntegrationTests.Controller.JobsCatalog.Command
{
   public class DeleteTechnology : IClassFixture<MyWebApplicationFactory<Startup>>
    {
        private readonly MyWebApplicationFactory<Startup> _factory;

        public DeleteTechnology(MyWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task DeleteTechnology_Deleted()
        {
            //arrange
            var client = await _factory.GetAuthenticatedClientAsync();

            //act
            var response = await client.DeleteAsync($"api/jobs/1/technologies/1/delete/");

            //assert
            response.StatusCode.ShouldBe(System.Net.HttpStatusCode.NoContent);
            response.IsSuccessStatusCode.ShouldBeTrue();
        }

        [Fact]
        public async Task DeleteTechnology_False_JobOfferDoesNOTExist()
        {
            //arrange
            var client = await _factory.GetAuthenticatedClientAsync();

            //act
            var response = await client.DeleteAsync($"api/jobs/1111/technologies/1/delete/").ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            response.Errors.Count().ShouldBe(2);
            var error = response.Errors.First();
            error.PropertyName.ShouldBe("JobOfferId");
            error.ErrorMessage.ShouldBe("JobOffer with id: 1111 does not exist in db");
            var error2 = response.Errors.Skip(1).First();
            error2.ErrorMessage.ShouldBe("Technology with id 1 does not exist in job identify by 1111");
        }

        [Fact]
        public async Task DeleteTechnology_False_TechnologyIdLesserThanZero()
        {
            //arrange
            var client = await _factory.GetAuthenticatedClientAsync();

            //act
            var response = await client.DeleteAsync($"api/jobs/1/technologies/-1/delete/").ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            response.Errors.Count().ShouldBe(2);
            var error = response.Errors.First();
            error.PropertyName.ShouldBe("TechnologyId");
            error.ErrorMessage.ShouldBe("Technology id has to be greater then 0, error caused by -1 value");
            var error2 = response.Errors.Skip(1).First();
            error2.ErrorMessage.ShouldBe("Technology with id -1 does not exist in job identify by 1");
        }

        [Fact]
        public async Task DeleteTechnology_False_JobOfferDoesNOTHaveTechologyId()
        {
            //arrange
            var client = await _factory.GetAuthenticatedClientAsync();

            //act
            var response = await client.DeleteAsync($"api/jobs/1/technologies/4/delete/").ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            response.Errors.Count().ShouldBe(1);
            var error = response.Errors.First();
            error.ErrorMessage.ShouldBe("Technology with id 4 does not exist in job identify by 1");
        }
    }
}
