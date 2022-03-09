using JobsCatalog.Application.Features.Additional.Queries;
using JobsCatalog.Application.Features.Additional.Queries.AveragePayment;
using JobsCatalogApi.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobsCatalog.API.Controllers
{
    [Route("api/stats")]
    [ApiController]
    public class StatisticsController : BaseController
    {
        [HttpGet("experienceLevel")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> CreateJob(string experienceLevel)
        {
            var vm = await Mediator.Send(new AveragePaymentQuery() { ExperienceLevelName = experienceLevel});
            return vm.ExperienceLevelSalariesDtos.Count == 0 ? NotFound() : Ok(vm);
        }
    }
}
