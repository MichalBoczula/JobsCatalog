using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Entities.Commands.AddJobDesc
{
    public class AddJobDescCommand : IRequest<int?>
    {
        public AddJobDescDto Model { get; set; }
        public int JobOfferId { get; set; }
    }
}
