using JobsCatalog.Application.Contracts.Tags;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Entities.Commands.DeleteTechnology
{
    public class DeleteTechnologyCommand : IRequest<int?>, ICommandTag
    {
        public int TechnologyId { get; set; }
        public int JobOfferId { get; set; }
    }
}
