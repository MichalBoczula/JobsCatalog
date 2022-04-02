using JobsCatalog.Application.Features.Entities.Commands.AddJobDesc;
using JobsCatalog.Application.Features.Entities.Commands.AddJobOffer;
using JobsCatalog.Application.Features.Entities.Commands.AddNewJobWholeObj;
using JobsCatalog.Application.Features.Entities.Commands.AddTechnology;
using JobsCatalog.Application.Features.Entities.Commands.DeleteJob;
using JobsCatalog.Application.Features.Entities.Commands.DeleteTechnology;
using JobsCatalog.Application.Features.Entities.Commands.UpdateJob;
using JobsCatalog.Application.Features.Entities.Commands.UpdateJobDescription;
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
        public async Task<ActionResult> GetJobsList()
        {
            var vm = await Mediator.Send(new JobsListQuery());
            return Ok(vm);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetJobDetails(int id)
        {
            var vm = await Mediator.Send(new JobDetailsQuery() { Id = id });
            return vm is null ? NotFound() : Ok(vm);
        }

        [HttpPost("AddWholeJobObj")]
        public async Task<ActionResult> CreateJobWithDescAndTechSet([FromBody] AddNewJobVm model)
        {
            var vm = await Mediator.Send(new AddNewJobCommand() { Model = model });
            return vm is null ? BadRequest() : CreatedAtAction(nameof(GetJobDetails), new { id = vm }, new { id = vm });
        }

        [HttpPost("addJobOffer")]
        public async Task<ActionResult> CreateJobOffer([FromBody] AddJobOfferDto model)
        {
            var vm = await Mediator.Send(new AddJobOfferCommand() { Model = model });
            return vm is null ? BadRequest() : CreatedAtAction(nameof(GetJobDetails), new { id = vm }, new { id = vm });
        }

        [HttpPost("{id}/addJobDesc")]
        public async Task<ActionResult> CreateJobDesc(int id, [FromBody] AddJobDescDto model)
        {
            var vm = await Mediator.Send(new AddJobDescCommand() { Model = model, JobOfferId = id});
            return vm is null ? BadRequest() : CreatedAtAction(nameof(GetJobDetails), new { id = vm }, new { id = vm });
        }

        [HttpPut("{id}/jobOffer/update")]
        public async Task<ActionResult> UpdateJob(int id, [FromBody] UpdateJobVm model)
        {
            var vm = await Mediator.Send(new UpdateJobCommand() { Model = model, Id = id });
            return vm is not null ? NoContent() : BadRequest();
        }

        [HttpDelete("{id}/jobOffer/delete")]
        public async Task<ActionResult> DeleteJobOffer(int id)
        {
            var vm = await Mediator.Send(new DeleteJobCommand() { Id = id });
            return vm is not null ? NoContent() : BadRequest();
        }

        [HttpPut("{id}/jobDescription/update")]
        public async Task<ActionResult> UpdateJobDescription(int id, [FromBody] UpdateJobDescriptionVm model)
        {
            var vm = await Mediator.Send(new UpdateJobDescriptionCommand() { Model = model, JobOfferId = id });
            return vm is not null ? NoContent() : BadRequest();
        }

        [HttpPost("{id}/technologies/add")]
        public async Task<ActionResult> AddTechnology(int id, [FromBody] List<int> technologies)
        {
            var vm = await Mediator.Send(new AddTechnologyCommand() { Technologies = technologies, JobOfferId = id });
            return vm is not null ? NoContent() : BadRequest();
        }

        [HttpDelete("{id}/technologies/delete")]
        public async Task<ActionResult> DeleteTechnology(int id, [FromBody] List<int> technologies)
        {
            var vm = await Mediator.Send(new DeleteTechnologyCommand() { Technologies = technologies, JobOfferId = id });
            return vm is not null ? NoContent() : BadRequest();
        }
    }
}
