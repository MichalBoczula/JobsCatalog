﻿using JobsCatalog.API;
using JobsCatalog.Application.Features.Dictionaries.Queries.ProgrammingLanguages;
using JobsCatalog.IntegrationTests.Common;
using JobsCatalog.IntegrationTests.Configuration;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace JobsCatalog.IntegrationTests.Controller.DictionaryController
{
    public class GetProgrammingLanguagesTests : IClassFixture<MyWebApplicationFactory<Startup>>
    {
        private readonly MyWebApplicationFactory<Startup> _factory;

        public GetProgrammingLanguagesTests(MyWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task GetProgrammingLanguages()
        {
            var client = await _factory.GetAuthenticatedClientAsync();

            var response = await client.GetAsync($"api/dictionaries/programmingLanguages");
            response.EnsureSuccessStatusCode();

            var vm = await Utilities.GetResponseContent<List<ProgrammingLanguageVm>>(response);
            vm.Count.ShouldBe(5);
        }
    }
}
