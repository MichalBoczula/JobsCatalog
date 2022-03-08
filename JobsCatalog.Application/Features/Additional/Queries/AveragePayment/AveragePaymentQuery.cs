﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Additional.Queries.AveragePayment
{
    public class AveragePaymentQuery : IRequest<AveragePaymentVm>
    {
        public string ExperienceLevelName { get; set; }
    }
}
