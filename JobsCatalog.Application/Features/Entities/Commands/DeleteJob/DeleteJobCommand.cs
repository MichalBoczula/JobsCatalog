using JobsCatalog.Application.Contracts.Tags;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Entities.Commands.DeleteJob
{
    public class DeleteJobCommand : IRequest<int>, ICommandTag
    {
        public int Id { get; set; }
    }
}
