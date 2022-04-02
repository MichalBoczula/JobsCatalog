using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Entities.Commands.AddNewJobWholeObj
{
    public class AddNewJobVm 
    {
        public AddJob_JobOfferDto JobOffer { get; set; }
        public AddJob_JobDescritpionDto JobDescritpion { get; set; }
        public List<int> Technologies { get; set; }

    }
}
