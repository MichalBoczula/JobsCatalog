﻿using JobsCatalog.Application.Contracts.Tags;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Entities.Commands.AddNewJobWholeObj
{
    public class AddNewJobCommand : IRequest<int?>, ICommandTag
    {
        public AddNewJobVm Model { get; set; }
    }
}