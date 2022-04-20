using JobsCatalog.API;
using JobsCatalog.Application.Features.Entities.Commands.AddJobOffer;
using JobsCatalog.Application.Features.Entities.Queries.JobDetails;
using JobsCatalog.IntegrationTests.Common;
using JobsCatalog.IntegrationTests.Configuration;
using Microsoft.AspNetCore.Mvc;
using Shouldly;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public async Task AddNewJobOffer_JobAdded()
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

        [Fact]
        public async Task AddNewJobOffer_False_PositionNameEmpty()
        {
            //arrange
            var positionName = "";
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
            var response = await client.PostAsJsonAsync($"api/jobs/addJobOffer", obj).ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            response.Errors.Count().ShouldBe(1);
            var error = response.Errors.First();
            error.PropertyName.ShouldBe("Model.PositionName");
            error.ErrorMessage.ShouldBe("'Model Position Name' must not be empty.");
        }

        [Fact]
        public async Task AddNewJobOffer_False_MinSalaryToLess()
        {
            //arrange
            var positionName = "test";
            var salaryMin = 1000;
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
            var response = await client.PostAsJsonAsync($"api/jobs/addJobOffer", obj).ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            response.Errors.Count().ShouldBe(1);
            var error = response.Errors.First();
            error.PropertyName.ShouldBe("Model.SalaryMin");
            error.ErrorMessage.ShouldBe("'Model Salary Min' must be greater than or equal to '2800'.");
        }

        [Fact]
        public async Task AddNewJobOffer_False_MaxSalaryLesserThanMinSalary()
        {
            //arrange
            var positionName = "test";
            var salaryMin = 4000;
            var salaryMax = 3000;
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
            var response = await client.PostAsJsonAsync($"api/jobs/addJobOffer", obj).ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            response.Errors.Count().ShouldBe(1);
            var error = response.Errors.First();
            error.PropertyName.ShouldBe("Model");
            error.ErrorMessage.ShouldBe("SalaryMax must be bigger than SalaryMin");
        }

        [Fact]
        public async Task AddNewJobOffer_False_CityEmpty()
        {
            //arrange
            var positionName = "test";
            var salaryMin = 4000;
            var salaryMax = 6000;
            var city = "";
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
            var response = await client.PostAsJsonAsync($"api/jobs/addJobOffer", obj).ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            response.Errors.Count().ShouldBe(1);
            var error = response.Errors.First();
            error.PropertyName.ShouldBe("Model.City");
            error.ErrorMessage.ShouldBe("'Model City' must not be empty.");
        }

        [Fact]
        public async Task AddNewJobOffer_False_ExperienceLevelDoesNOTExist()
        {
            //arrange
            var positionName = "test";
            var salaryMin = 4000;
            var salaryMax = 6000;
            var city = "test city";
            var client = await _factory.GetAuthenticatedClientAsync();
            var obj = new AddJobOfferDto
            {
                PositionName = positionName,
                SalaryMin = salaryMin,
                SalaryMax = salaryMax,
                City = city,
                ExperienceLevelId = 0,
                CompanyId = 2,
                ProgrammingLanguageId = 4
            };

            //act
            var response = await client.PostAsJsonAsync($"api/jobs/addJobOffer", obj).ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            response.Errors.Count().ShouldBe(1);
            var error = response.Errors.First();
            error.PropertyName.ShouldBe("Model.ExperienceLevelId");
            error.ErrorMessage.ShouldBe("ExperienceLevel must exists in dictionary");
        }

        [Fact]
        public async Task AddNewJobOffer_False_CompanyDoesNOTExist()
        {
            //arrange
            var positionName = "test";
            var salaryMin = 4000;
            var salaryMax = 6000;
            var city = "test city";
            var client = await _factory.GetAuthenticatedClientAsync();
            var obj = new AddJobOfferDto
            {
                PositionName = positionName,
                SalaryMin = salaryMin,
                SalaryMax = salaryMax,
                City = city,
                ExperienceLevelId = 1,
                CompanyId = 2222222,
                ProgrammingLanguageId = 4
            };

            //act
            var response = await client.PostAsJsonAsync($"api/jobs/addJobOffer", obj).ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            response.Errors.Count().ShouldBe(1);
            var error = response.Errors.First();
            error.PropertyName.ShouldBe("Model.CompanyId");
            error.ErrorMessage.ShouldBe("Company must exists in dataBase");
        }

        [Fact]
        public async Task AddNewJobOffer_False_ProgrammingLanguageDoesNOTExist()
        {
            //arrange
            var positionName = "test";
            var salaryMin = 4000;
            var salaryMax = 6000;
            var city = "test city";
            var client = await _factory.GetAuthenticatedClientAsync();
            var obj = new AddJobOfferDto
            {
                PositionName = positionName,
                SalaryMin = salaryMin,
                SalaryMax = salaryMax,
                City = city,
                ExperienceLevelId = 1,
                CompanyId = 2,
                ProgrammingLanguageId = 4444444
            };

            //act
            var response = await client.PostAsJsonAsync($"api/jobs/addJobOffer", obj).ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            response.Errors.Count().ShouldBe(1);
            var error = response.Errors.First();
            error.PropertyName.ShouldBe("Model.ProgrammingLanguageId");
            error.ErrorMessage.ShouldBe("ProgrammingLanguage must exists in dictionary");
        }
    }
}