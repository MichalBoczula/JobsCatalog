using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Entities.Commands.AddJobOffer
{
    public class AddJobOfferCommand : IRequest<int?>
    {
        public AddJobOfferDto Model { get; set; }
    }
}
