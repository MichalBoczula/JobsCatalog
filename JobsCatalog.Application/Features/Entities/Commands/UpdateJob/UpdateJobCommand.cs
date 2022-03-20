using JobsCatalog.Application.Contracts.Tags;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Entities.Commands.UpdateJob
{
   public class UpdateJobCommand : IRequest<int?>, ICommandTag
    {
        public UpdateJobVm Model { get; set; }
        public int Id { get; set; }
    }
}
