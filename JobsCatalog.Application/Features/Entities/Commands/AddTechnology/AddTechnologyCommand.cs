using JobsCatalog.Application.Contracts.Tags;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Entities.Commands.AddTechnology
{
    public class AddTechnologyCommand : IRequest<List<int>>, ICommandTag
    {
        public List<int> Technologies { get; set; }
        public int JobOfferId { get; set; }
    }
}
