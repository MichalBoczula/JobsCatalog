﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Entities.Commands.UpdateJobDescription
{
    public class UpdateJobDescriptionCommand : IRequest<int>
    {
        public UpdateJobDescriptionVm Model { get; set; }
        public int JobOfferId { get; set; }
    }
}
