using JobsCatalog.API;
using JobsCatalog.IntegrationTests.Common;
using JobsCatalog.IntegrationTests.Configuration;
using Microsoft.AspNetCore.Mvc;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace JobsCatalog.IntegrationTests.Controller.JobsCatalog.Command
{
    public class DeleteJob : IClassFixture<MyWebApplicationFactory<Startup>>
    {
        private readonly MyWebApplicationFactory<Startup> _factory;

        public DeleteJob(MyWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task DeleteJob_JobDeleted()
        {
            //arrange
            var client = await _factory.GetAuthenticatedClientAsync();
            var Id = 1;

            //act
            var response = await client.DeleteAsync($"api/jobs/{Id}/jobOffer/delete");

            //assert
            response.StatusCode.ShouldBe(System.Net.HttpStatusCode.NoContent);
            response.IsSuccessStatusCode.ShouldBeTrue();
        }

        [Fact]
        public async Task DeleteJob_JobDoesNOTExist()
        {
            //arrange
            var client = await _factory.GetAuthenticatedClientAsync();
            var Id = 1111;

            //act
            var response = await client.DeleteAsync($"api/jobs/{Id}/jobOffer/delete").ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            response.Errors.Count().ShouldBe(1);
            var error = response.Errors.First();
            error.PropertyName.ShouldBe("Id");
            error.ErrorMessage.ShouldBe($"JobOffer with id: {Id} does not exist in db");
        }

    }
}
