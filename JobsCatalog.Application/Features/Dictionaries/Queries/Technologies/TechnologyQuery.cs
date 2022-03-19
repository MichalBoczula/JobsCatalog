using JobsCatalog.Application.Contracts.Tags;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsCatalog.Application.Features.Dictionaries.Queries.Technologies
{
    public class TechnologyQuery : IRequest<List<TechnologyVm>>, IQueryTag
    {
    }
}
