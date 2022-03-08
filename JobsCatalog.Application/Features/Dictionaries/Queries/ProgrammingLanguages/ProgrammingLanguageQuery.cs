using MediatR;
using System.Collections.Generic;

namespace JobsCatalog.Application.Features.Dictionaries.Queries.ProgrammingLanguages
{
    public class ProgrammingLanguageQuery : IRequest<List<ProgrammingLanguageVm>>
    {
    }
}
