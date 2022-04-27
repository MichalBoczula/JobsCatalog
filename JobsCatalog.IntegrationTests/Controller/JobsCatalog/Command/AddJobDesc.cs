using JobsCatalog.API;
using JobsCatalog.Application.Features.Entities.Commands.AddJobDesc;
using JobsCatalog.Application.Features.Entities.Commands.AddJobOffer;
using JobsCatalog.IntegrationTests.Common;
using JobsCatalog.IntegrationTests.Configuration;
using Microsoft.AspNetCore.Mvc;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Xunit;

namespace JobsCatalog.IntegrationTests.Controller.JobsCatalog.Command
{
    [Collection("AddJobDesc")]
    public class AddJobDesc : IClassFixture<MyWebApplicationFactory<Startup>>
    {
        private readonly MyWebApplicationFactory<Startup> _factory;

        public AddJobDesc(MyWebApplicationFactory<Startup> factory)
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
            var about = "about";
            var expectation = "expectation";
            var responsibilities = "responsibilities";
            var offer = "offer";
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
            var response = await client.PostAsJsonAsync($"api/jobs/addJobOffer", obj);
            var jobOfferJson = await response.Content.ReadAsStringAsync();
            var jobOfferId = int.Parse(new string(jobOfferJson.Where((x, idx) => idx > 5 && idx < 8).ToArray()));

            var jobDesc = new AddJobDescDto
            {
                About = about,
                Expectation = expectation,
                Responsibilities = responsibilities,
                Offer = offer
            };

            //act
            var responseAfterAddedJobDesc = await client.PostAsJsonAsync($"api/jobs/{jobOfferId}/addJobDesc", jobDesc);
            var jobDescJson = await Utilities.GetResponseContent<CreatedAtActionResult>(responseAfterAddedJobDesc);
            var jobDescId = await responseAfterAddedJobDesc.Content.ReadAsStringAsync();

            //assert
            jobDescJson.StatusCode.ShouldBe(201);
            jobDescId.ShouldBe("{\"id\":16}");
        }

        [Fact]
        public async Task AddNewJobOffer_False_AboutEmpty()
        {
            //arrange
            var positionName = "test";
            var salaryMin = 3000;
            var salaryMax = 6000;
            var city = "city test";
            var about = "";
            var expectation = "expectation";
            var responsibilities = "responsibilities";
            var offer = "offer";
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
            var response = await client.PostAsJsonAsync($"api/jobs/addJobOffer", obj);
            var jobOfferJson = await response.Content.ReadAsStringAsync();
            var jobOfferId = int.Parse(new string(jobOfferJson.Where((x, idx) => idx > 5 && idx < 8).ToArray()));

            var jobDesc = new AddJobDescDto
            {
                About = about,
                Expectation = expectation,
                Responsibilities = responsibilities,
                Offer = offer
            };

            //act
            var responseAfterAddedJobDesc = await client.PostAsJsonAsync($"api/jobs/{jobOfferId}/addJobDesc", jobDesc)
                .ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            responseAfterAddedJobDesc.Errors.Count().ShouldBe(1);
            var error = responseAfterAddedJobDesc.Errors.First();
            error.PropertyName.ShouldBe("Model.About");
            error.ErrorMessage.ShouldBe("'Model About' must not be empty.");
        }

        [Fact]
        public async Task AddNewJobOffer_False_ExpectationEmpty()
        {
            //arrange
            var positionName = "test";
            var salaryMin = 3000;
            var salaryMax = 6000;
            var city = "city test";
            var about = "about";
            var expectation = "";
            var responsibilities = "responsibilities";
            var offer = "offer";
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
            var response = await client.PostAsJsonAsync($"api/jobs/addJobOffer", obj);
            var jobOfferJson = await response.Content.ReadAsStringAsync();
            var jobOfferId = int.Parse(new string(jobOfferJson.Where((x, idx) => idx > 5 && idx < 8).ToArray()));

            var jobDesc = new AddJobDescDto
            {
                About = about,
                Expectation = expectation,
                Responsibilities = responsibilities,
                Offer = offer
            };

            //act
            var responseAfterAddedJobDesc = await client.PostAsJsonAsync($"api/jobs/{jobOfferId}/addJobDesc", jobDesc)
                .ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            responseAfterAddedJobDesc.Errors.Count().ShouldBe(1);
            var error = responseAfterAddedJobDesc.Errors.First();
            error.PropertyName.ShouldBe("Model.Expectation");
            error.ErrorMessage.ShouldBe("'Model Expectation' must not be empty.");
        }

        [Fact]
        public async Task AddNewJobOffer_False_ResponsibilitiesEmpty()
        {
            //arrange
            var positionName = "test";
            var salaryMin = 3000;
            var salaryMax = 6000;
            var city = "city test";
            var about = "about";
            var expectation = "expectation";
            var responsibilities = "";
            var offer = "offer";
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
            var response = await client.PostAsJsonAsync($"api/jobs/addJobOffer", obj);
            var jobOfferJson = await response.Content.ReadAsStringAsync();
            var jobOfferId = int.Parse(new string(jobOfferJson.Where((x, idx) => idx > 5 && idx < 8).ToArray()));

            var jobDesc = new AddJobDescDto
            {
                About = about,
                Expectation = expectation,
                Responsibilities = responsibilities,
                Offer = offer
            };

            //act
            var responseAfterAddedJobDesc = await client.PostAsJsonAsync($"api/jobs/{jobOfferId}/addJobDesc", jobDesc)
                .ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            responseAfterAddedJobDesc.Errors.Count().ShouldBe(1);
            var error = responseAfterAddedJobDesc.Errors.First();
            error.PropertyName.ShouldBe("Model.Responsibilities");
            error.ErrorMessage.ShouldBe("'Model Responsibilities' must not be empty.");
        }

        [Fact]
        public async Task AddNewJobOffer_False_OfferEmpty()
        {
            //arrange
            var positionName = "test";
            var salaryMin = 3000;
            var salaryMax = 6000;
            var city = "city test";
            var about = "about";
            var expectation = "expectation";
            var responsibilities = "responsibilities";
            var offer = "";
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
            var response = await client.PostAsJsonAsync($"api/jobs/addJobOffer", obj);
            var jobOfferJson = await response.Content.ReadAsStringAsync();
            var jobOfferId = int.Parse(new string(jobOfferJson.Where((x, idx) => idx > 5 && idx < 8).ToArray()));

            var jobDesc = new AddJobDescDto
            {
                About = about,
                Expectation = expectation,
                Responsibilities = responsibilities,
                Offer = offer
            };

            //act
            var responseAfterAddedJobDesc = await client.PostAsJsonAsync($"api/jobs/{jobOfferId}/addJobDesc", jobDesc)
                .ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            responseAfterAddedJobDesc.Errors.Count().ShouldBe(1);
            var error = responseAfterAddedJobDesc.Errors.First();
            error.PropertyName.ShouldBe("Model.Offer");
            error.ErrorMessage.ShouldBe("'Model Offer' must not be empty.");
        }

        [Fact]
        public async Task AddNewJobOffer_False_JobOfferDoesNOTExist()
        {
            //arrange
            var about = "about";
            var expectation = "expectation";
            var responsibilities = "responsibilities";
            var offer = "offer";
            var client = await _factory.GetAuthenticatedClientAsync();
            
            var jobDesc = new AddJobDescDto
            {
                About = about,
                Expectation = expectation,
                Responsibilities = responsibilities,
                Offer = offer
            };

            //act
            var responseAfterAddedJobDesc = await client.PostAsJsonAsync($"api/jobs/1111/addJobDesc", jobDesc)
                .ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            responseAfterAddedJobDesc.Errors.Count().ShouldBe(1);
            var error = responseAfterAddedJobDesc.Errors.First();
            error.PropertyName.ShouldBe("JobOfferId");
            error.ErrorMessage.ShouldBe("Job Offer must exists in dataBase");
        }

        [Fact]
        public async Task AddNewJobOffer_False_JobOfferHasHadDesc()
        {
            //arrange
            var about = "about";
            var expectation = "expectation";
            var responsibilities = "responsibilities";
            var offer = "offer";
            var client = await _factory.GetAuthenticatedClientAsync();

            var jobDesc = new AddJobDescDto
            {
                About = about,
                Expectation = expectation,
                Responsibilities = responsibilities,
                Offer = offer
            };

            //act
            var responseAfterAddedJobDesc = await client.PostAsJsonAsync($"api/jobs/1/addJobDesc", jobDesc)
                .ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            responseAfterAddedJobDesc.Errors.Count().ShouldBe(1);
            var error = responseAfterAddedJobDesc.Errors.First();
            error.PropertyName.ShouldBe("JobOfferId");
            error.ErrorMessage.ShouldBe("Job Offer has had description already");
        }
    }
}
