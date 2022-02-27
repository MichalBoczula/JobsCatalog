using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsCatalog.Application.Features.Entities.Queries.JobDetails
{
    public class JobDetailsQuery : IRequest<JobDetailsVm>
    {
        public int Id { get; set; }
    }
}
