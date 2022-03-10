using JobsCatalog.Application.Features.Entities.Commands.AddNewJob;
using JobsCatalog.Application.Features.Entities.Commands.UpdateJob;
using JobsCatalog.Application.Features.Entities.Queries.JobDetails;
using JobsCatalog.Application.Features.Entities.Queries.JobsList;
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
    [Route("api/jobs")]
    [ApiController]
    public class JobsCatalogController : BaseController
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetJobsList()
        {
            var vm = await Mediator.Send(new JobsListQuery());
            return Ok(vm);
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetJobDetails(int id)
        {
            var vm = await Mediator.Send(new JobDetailsQuery() { Id = id});
            return vm is null? NotFound() : Ok(vm);
        }

        [HttpPost("add")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> CreateJob([FromBody] AddNewJobVm model) 
        {
            var vm = await Mediator.Send(new AddNewJobCommand() { Model = model });
            return CreatedAtAction(nameof(GetJobDetails), new { id = vm}, new { id = vm });
        }

        [HttpPut("{id}/update")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> UpdateJob(int id, [FromBody] UpdateJobVm model)
        {
            var vm = await Mediator.Send(new UpdateJobCommand() { Model = model, Id = id });
            return NoContent();
        }

        [HttpPut("{id}/jobList/update")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> UpdateJobList(int id, [FromBody] AddNewJobVm model)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}/jobDescription/update")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> UpdateJobdescription(int id, [FromBody] AddNewJobVm model)
        {
            throw new NotImplementedException();
        }
    }
}
