using MediatR;
using System.Collections.Generic;

namespace JobsCatalog.Application.Features.Entities.Queries.JobsList
{
    public class JobsListQuery : IRequest<List<JobsListVm>>
    {
    }
}
