using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using JobsCatalog.API;
using JobsCatalog.Application.Features.Entities.Commands.AddJobOffer;
using JobsCatalog.Application.Features.Entities.Commands.UpdateJob;
using JobsCatalog.IntegrationTests.Common;
using JobsCatalog.IntegrationTests.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shouldly;
using Xunit;

namespace JobsCatalog.IntegrationTests.Controller.JobsCatalog.Command
{
    [Collection("UpdateJobOffer")]
    public class UpdateJob : IClassFixture<MyWebApplicationFactory<Startup>>
    {
        private readonly MyWebApplicationFactory<Startup> _factory;

        public UpdateJob(MyWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task UpdateJob_Update()
        {
            //arrange
            var client = await _factory.GetAuthenticatedClientAsync();
            var obj = new UpdateJobVm
            {
                PositionName = "Junior .Net Developer",
                SalaryMin = 6000,
                SalaryMax = 9000,
                City = "Wroclaw test",
                ExperienceLevelId = 1,
                CompanyId = 1,
                ProgrammingLanguageId = 1,
            };
               
            //act
            var response = await client.PutAsJsonAsync($"api/jobs/1/JobOffer/update", obj);

            //assert
            response.StatusCode.ShouldBe(System.Net.HttpStatusCode.NoContent);
            response.IsSuccessStatusCode.ShouldBeTrue();
        }

        [Fact]
        public async Task UpdateJob_False_PositionNameEmpty()
        {
            //arrange
            var client = await _factory.GetAuthenticatedClientAsync();
            var obj = new UpdateJobVm
            {
                PositionName = "",
                SalaryMin = 4000,
                SalaryMax = 6000,
                City = "Wroclaw test",
                ExperienceLevelId = 1,
                CompanyId = 1,
                ProgrammingLanguageId = 1,
            };

            //act
            var response = await client.PutAsJsonAsync($"api/jobs/1/JobOffer/update", obj).ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            response.Errors.Count().ShouldBe(1);
            var error = response.Errors.First();
            error.PropertyName.ShouldBe("Model.PositionName");
            error.ErrorMessage.ShouldBe("'Model Position Name' must not be empty.");
        }

        [Fact]
        public async Task UpdateJob_False_SalaryMinToLow()
        {
            //arrange
            var client = await _factory.GetAuthenticatedClientAsync();
            var obj = new UpdateJobVm
            {
                PositionName = "Junior .Net Developer",
                SalaryMin = 2700,
                SalaryMax = 6000,
                City = "Wroclaw test",
                ExperienceLevelId = 1,
                CompanyId = 1,
                ProgrammingLanguageId = 1,
            };

            //act
            var response = await client.PutAsJsonAsync($"api/jobs/1/JobOffer/update", obj).ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            response.Errors.Count().ShouldBe(1);
            var error = response.Errors.First();
            error.PropertyName.ShouldBe("Model.SalaryMin");
            error.ErrorMessage.ShouldBe("'Model Salary Min' must be greater than or equal to '2800'.");
        }

        [Fact]
        public async Task UpdateJob_False_SalaryMaxLowerThanSalaryMin()
        {
            //arrange
            var client = await _factory.GetAuthenticatedClientAsync();
            var obj = new UpdateJobVm
            {
                PositionName = "Junior .Net Developer",
                SalaryMin = 4000,
                SalaryMax = 3000,
                City = "Wroclaw test",
                ExperienceLevelId = 1,
                CompanyId = 1,
                ProgrammingLanguageId = 1,
            };

            //act
            var response = await client.PutAsJsonAsync($"api/jobs/1/JobOffer/update", obj).ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            response.Errors.Count().ShouldBe(1);
            var error = response.Errors.First();
            error.PropertyName.ShouldBe("Model");
            error.ErrorMessage.ShouldBe("SalaryMax must be bigger than SalaryMin");
        }

        [Fact]
        public async Task UpdateJob_False_CityDoesNOTExist()
        {
            //arrange
            var client = await _factory.GetAuthenticatedClientAsync();
            var obj = new UpdateJobVm
            {
                PositionName = "Junior .Net Developer",
                SalaryMin = 3000,
                SalaryMax = 4000,
                City = "",
                ExperienceLevelId = 1,
                CompanyId = 1,
                ProgrammingLanguageId = 1,
            };

            //act
            var response = await client.PutAsJsonAsync($"api/jobs/1/JobOffer/update", obj).ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            response.Errors.Count().ShouldBe(1);
            var error = response.Errors.First();
            error.PropertyName.ShouldBe("Model.City");
            error.ErrorMessage.ShouldBe("'Model City' must not be empty.");
        }

        [Fact]
        public async Task UpdateJob_False_ExperienceLevelDoesNOTExist()
        {
            //arrange
            var client = await _factory.GetAuthenticatedClientAsync();
            var obj = new UpdateJobVm
            {
                PositionName = "Junior .Net Developer",
                SalaryMin = 3000,
                SalaryMax = 4000,
                City = "Wroclaw",
                ExperienceLevelId = 11,
                CompanyId = 1,
                ProgrammingLanguageId = 1,
            };

            //act
            var response = await client.PutAsJsonAsync($"api/jobs/1/JobOffer/update", obj).ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            response.Errors.Count().ShouldBe(1);
            var error = response.Errors.First();
            error.PropertyName.ShouldBe("Model.ExperienceLevelId");
            error.ErrorMessage.ShouldBe("ExperienceLevel must exists in dictionary");
        }

        [Fact]
        public async Task UpdateJob_False_CompanyDoesNOTExist()
        {
            //arrange
            var client = await _factory.GetAuthenticatedClientAsync();
            var obj = new UpdateJobVm
            {
                PositionName = "Junior .Net Developer",
                SalaryMin = 3000,
                SalaryMax = 4000,
                City = "Wroclaw",
                ExperienceLevelId = 1,
                CompanyId = 123,
                ProgrammingLanguageId = 1,
            };

            //act
            var response = await client.PutAsJsonAsync($"api/jobs/1/JobOffer/update", obj).ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            response.Errors.Count().ShouldBe(1);
            var error = response.Errors.First();
            error.PropertyName.ShouldBe("Model.CompanyId");
            error.ErrorMessage.ShouldBe("Company must exists in dataBase");
        }

        [Fact]
        public async Task UpdateJob_False_ProgrammingLanguageIdDoesNOTExist()
        {
            //arrange
            var client = await _factory.GetAuthenticatedClientAsync();
            var obj = new UpdateJobVm
            {
                PositionName = "Junior .Net Developer",
                SalaryMin = 3000,
                SalaryMax = 4000,
                City = "Wroclaw",
                ExperienceLevelId = 1,
                CompanyId = 1,
                ProgrammingLanguageId = 123,
            };

            //act
            var response = await client.PutAsJsonAsync($"api/jobs/1/JobOffer/update", obj).ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            response.Errors.Count().ShouldBe(1);
            var error = response.Errors.First();
            error.PropertyName.ShouldBe("Model.ProgrammingLanguageId");
            error.ErrorMessage.ShouldBe("ProgrammingLanguage must exist in dictionary");
        }

        [Fact]
        public async Task UpdateJob_False_JobOfferDoesNOTExist()
        {
            //arrange
            var client = await _factory.GetAuthenticatedClientAsync();
            var obj = new UpdateJobVm
            {
                PositionName = "Junior .Net Developer",
                SalaryMin = 3000,
                SalaryMax = 4000,
                City = "Wroclaw",
                ExperienceLevelId = 1,
                CompanyId = 1,
                ProgrammingLanguageId = 1,
            };

            //act
            var response = await client.PutAsJsonAsync($"api/jobs/1111/JobOffer/update", obj).ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            response.Errors.Count().ShouldBe(1);
            var error = response.Errors.First();
            error.PropertyName.ShouldBe("Id");
            error.ErrorMessage.ShouldBe($"JobOffer with id: 1111 does not exist in db");
        }
    }
}
