using JobsCatalog.Application.Features.Dictionaries.Queries.ExperienceLevels;
using JobsCatalog.Application.Features.Dictionaries.Queries.ProgrammingLanguages;
using JobsCatalog.Application.Features.Dictionaries.Queries.Technologies;
using JobsCatalogApi.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsCatalogApi.Controllers
{
    [Route("api/dictionaries")]
    [ApiController]
    public class DictionaryController : BaseController
    {
        [HttpGet("experienceLevels")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ExperienceLevelVm>> GetExperienceLevels()
        {
            var vm = await Mediator.Send(new ExperienceLevelQuery());
            return Ok(vm);
        }

        [HttpGet("programmingLanguages")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<ProgrammingLanguageVm>>> GetProgrammingLanguages()
        {
            var vm = await Mediator.Send(new ProgrammingLanguageQuery());
            return Ok(vm);
        }

        [HttpGet("technologies")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TechnologyVm>> GetTechnologies()
        {
            var vm = await Mediator.Send(new TechnologyQuery());
            return Ok(vm);
        }
    }
}
