using JobsCatalog.Application.Contracts.Tags;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsCatalog.Application.Features.Dictionaries.Queries.ExperienceLevels
{
    public class ExperienceLevelQuery : IRequest<List<ExperienceLevelVm>>, IQueryTag
    {

    }
}
