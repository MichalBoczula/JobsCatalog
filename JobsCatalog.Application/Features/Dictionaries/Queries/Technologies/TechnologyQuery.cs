using MediatR;
using System.Collections.Generic;

namespace JobsCatalog.Application.Features.Dictionaries.Queries.Technologies
{
    public class TechnologyQuery : IRequest<List<TechnologyVm>>
    {
    }
}
