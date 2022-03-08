using MediatR;

namespace JobsCatalog.Application.Features.Entities.Commands.AddNewJob
{
    public class AddNewJobCommand : IRequest<int>
    {
        public AddNewJobVm Model { get; set; }
        public bool IsProductionMode { get; set; } = true;
    }
}
