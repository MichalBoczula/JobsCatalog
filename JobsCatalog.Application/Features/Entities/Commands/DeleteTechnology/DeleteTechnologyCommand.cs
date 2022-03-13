﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Entities.Commands.DeleteTechnology
{
    public class DeleteTechnologyCommand : IRequest<int>
    {
        public List<int> Technologies{ get; set; }
        public int JobOfferId { get; set; }
    }
}