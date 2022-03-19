using JobsCatalog.Application.Contracts.Tags;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsCatalog.Application.Features.Entities.Queries.JobDetails
{
    public class JobDetailsQuery : IRequest<JobDetailsVm>, IQueryTag
    {
        public int Id { get; set; }
    }
}
