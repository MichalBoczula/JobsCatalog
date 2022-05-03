using JobsCatalog.API;
using JobsCatalog.Application.Features.Entities.Commands.AddJobDesc;
using JobsCatalog.Application.Features.Entities.Commands.AddJobOffer;
using JobsCatalog.Application.Features.Entities.Commands.UpdateJobDescription;
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
    public class UpdateJobDesc : IClassFixture<MyWebApplicationFactory<Startup>>
    {
        private readonly MyWebApplicationFactory<Startup> _factory;

        public UpdateJobDesc(MyWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task UpdateJobDesc_Update()
        {
            //arrange
            var about = "about test";
            var expectation = "expectation test";
            var responsibilities = "responsibilities test";
            var offer = "offer test";
            var client = await _factory.GetAuthenticatedClientAsync();

            var jobDesc = new UpdateJobDescriptionVm
            {
                About = about,
                Expectation = expectation,
                Responsibilities = responsibilities,
                Offer = offer
            };

            //act
            var responseAfterAddedJobDesc = await client.PutAsJsonAsync($"api/jobs/1/jobDescription/update", jobDesc);

            //assert
            responseAfterAddedJobDesc.StatusCode.ShouldBe(System.Net.HttpStatusCode.NoContent);
            responseAfterAddedJobDesc.IsSuccessStatusCode.ShouldBeTrue();
        }

        [Fact]
        public async Task UpdateJobDesc_False_AboutEmpty()
        {
            //arrange
            var about = "";
            var expectation = "expectation test";
            var responsibilities = "responsibilities test";
            var offer = "offer test";
            var client = await _factory.GetAuthenticatedClientAsync();

            var jobDesc = new UpdateJobDescriptionVm
            {
                About = about,
                Expectation = expectation,
                Responsibilities = responsibilities,
                Offer = offer
            };

            //act
            var responseAfterAddedJobDesc = await client.PutAsJsonAsync($"api/jobs/1/jobDescription/update", jobDesc)
                .ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            responseAfterAddedJobDesc.Errors.Count().ShouldBe(1);
            var error = responseAfterAddedJobDesc.Errors.First();
            error.PropertyName.ShouldBe("Model.About");
            error.ErrorMessage.ShouldBe("'Model About' must not be empty.");
        }

        [Fact]
        public async Task UpdateJobDesc_False_ExpectationEmpty()
        {
            //arrange
            var about = "about test";
            var expectation = "";
            var responsibilities = "responsibilities test";
            var offer = "offer test";
            var client = await _factory.GetAuthenticatedClientAsync();

            var jobDesc = new UpdateJobDescriptionVm
            {
                About = about,
                Expectation = expectation,
                Responsibilities = responsibilities,
                Offer = offer
            };

            //act
            var responseAfterAddedJobDesc = await client.PutAsJsonAsync($"api/jobs/1/jobDescription/update", jobDesc)
                .ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            responseAfterAddedJobDesc.Errors.Count().ShouldBe(1);
            var error = responseAfterAddedJobDesc.Errors.First();
            error.PropertyName.ShouldBe("Model.Expectation");
            error.ErrorMessage.ShouldBe("'Model Expectation' must not be empty.");
        }

        [Fact]
        public async Task UpdateJobDesc_False_ResponsibilitiesEmpty()
        {
            //arrange
            var about = "about test";
            var expectation = "expectation test";
            var responsibilities = "";
            var offer = "offer test";
            var client = await _factory.GetAuthenticatedClientAsync();

            var jobDesc = new UpdateJobDescriptionVm
            {
                About = about,
                Expectation = expectation,
                Responsibilities = responsibilities,
                Offer = offer
            };

            //act
            var responseAfterAddedJobDesc = await client.PutAsJsonAsync($"api/jobs/1/jobDescription/update", jobDesc)
                .ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            responseAfterAddedJobDesc.Errors.Count().ShouldBe(1);
            var error = responseAfterAddedJobDesc.Errors.First();
            error.PropertyName.ShouldBe("Model.Responsibilities");
            error.ErrorMessage.ShouldBe("'Model Responsibilities' must not be empty.");
        }

        [Fact]
        public async Task UpdateJobDesc_False_OfferEmpty()
        {
            //arrange
            var about = "about test";
            var expectation = "expectation test";
            var responsibilities = "responsibilities test";
            var offer = "";
            var client = await _factory.GetAuthenticatedClientAsync();

            var jobDesc = new UpdateJobDescriptionVm
            {
                About = about,
                Expectation = expectation,
                Responsibilities = responsibilities,
                Offer = offer
            };

            //act
            var responseAfterAddedJobDesc = await client.PutAsJsonAsync($"api/jobs/1/jobDescription/update", jobDesc)
                .ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            responseAfterAddedJobDesc.Errors.Count().ShouldBe(1);
            var error = responseAfterAddedJobDesc.Errors.First();
            error.PropertyName.ShouldBe("Model.Offer");
            error.ErrorMessage.ShouldBe("'Model Offer' must not be empty.");
        }

        [Fact]
        public async Task UpdateJobDesc_False_JobOfferDoesNOTExist()
        {
            //arrange
            var about = "about test";
            var expectation = "expectation test";
            var responsibilities = "responsibilities test";
            var offer = "offer test";
            var client = await _factory.GetAuthenticatedClientAsync();

            var jobDesc = new UpdateJobDescriptionVm
            {
                About = about,
                Expectation = expectation,
                Responsibilities = responsibilities,
                Offer = offer
            };

            //act
            var responseAfterAddedJobDesc = await client.PutAsJsonAsync($"api/jobs/1111/jobDescription/update", jobDesc)
                .ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            responseAfterAddedJobDesc.Errors.Count().ShouldBe(2);
            var error = responseAfterAddedJobDesc.Errors.First();
            error.PropertyName.ShouldBe("JobOfferId");
            error.ErrorMessage.ShouldBe("JobOffer with id: 1111 does not exist in db");
            var error2 = responseAfterAddedJobDesc.Errors.Skip(1).First();
            error2.PropertyName.ShouldBe("JobOfferId");
            error2.ErrorMessage.ShouldBe("JobDesc for JobOffer with Id: 1111 does not exist in db");
        }

        [Fact]
        public async Task UpdateJobDesc_False_JobDescDoesNOTExist()
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

            var jobDesc = new UpdateJobDescriptionVm
            {
                About = about,
                Expectation = expectation,
                Responsibilities = responsibilities,
                Offer = offer
            };

            //act
            var responseAfterAddedJobDesc = await client.PutAsJsonAsync($"api/jobs/{jobOfferId}/jobDescription/update", jobDesc)
                .ShouldThrowAsync<FluentValidation.ValidationException>();

            //assert
            responseAfterAddedJobDesc.Errors.Count().ShouldBe(1);
            var error = responseAfterAddedJobDesc.Errors.First();
            error.PropertyName.ShouldBe("JobOfferId");
            error.ErrorMessage.ShouldBe("JobDesc for JobOffer with Id: 16 does not exist in db");
        }
    }
}
