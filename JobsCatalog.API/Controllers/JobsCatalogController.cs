using JobsCatalog.Application.Features.Entities.Commands.AddNewJob;
using JobsCatalog.Application.Features.Entities.Queries.JobDetails;
using JobsCatalog.Application.Features.Entities.Queries.JobsList;
using JobsCatalogApi.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JobsCatalogApi.Controllers
{
    [Route("api/jobs")]
    [ApiController]
    public class JobsCatalogController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult> GetJobsList()
        {
            var vm = await Mediator.Send(new JobsListQuery());
            return Ok(vm);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetJobDetails(int id)
        {
            var vm = await Mediator.Send(new JobDetailsQuery() { Id = id});
            return vm is null? NotFound() : Ok(vm);
        }

        [HttpPost("add")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult> CreateJob([FromBody] AddNewJobVm model) 
        {
            var vm = await Mediator.Send(new AddNewJobCommand() { Model = model });
            return CreatedAtAction(nameof(GetJobDetails), new { id = vm}, new { id = vm });
        }
    }
}
