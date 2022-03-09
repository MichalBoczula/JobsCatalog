using System.Collections.Generic;

namespace JobsCatalog.Application.Features.Entities.Commands.UpdateJob
{
    public class UpdateJobVm
    {
        public int Id { get; set; }
        public string PositionName { get; set; }
        public int SalaryMin { get; set; }
        public int SalaryMax { get; set; }
        public string City { get; set; }
        public int ExperienceLevelId { get; set; }
        public int CompanyId { get; set; }
        public int ProgrammingLanguageId { get; set; }
    }
}