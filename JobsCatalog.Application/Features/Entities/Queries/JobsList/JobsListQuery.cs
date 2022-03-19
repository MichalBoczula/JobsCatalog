using JobsCatalog.Application.Contracts.Tags;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsCatalog.Application.Features.Entities.Queries.JobsList
{
    public class JobsListQuery : IRequest<List<JobsListVm>>, IQueryTag
    {
    }
}
