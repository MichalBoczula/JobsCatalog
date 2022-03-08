using MediatR;

namespace JobsCatalog.Application.Features.Entities.Queries.JobDetails
{
    public class JobDetailsQuery : IRequest<JobDetailsVm>
    {
        public int Id { get; set; }
    }
}
