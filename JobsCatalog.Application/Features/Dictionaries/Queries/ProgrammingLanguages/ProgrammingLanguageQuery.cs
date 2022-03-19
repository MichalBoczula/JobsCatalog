using JobsCatalog.Application.Contracts.Tags;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsCatalog.Application.Features.Dictionaries.Queries.ProgrammingLanguages
{
    public class ProgrammingLanguageQuery : IRequest<List<ProgrammingLanguageVm>>, IQueryTag
    {
    }
}
