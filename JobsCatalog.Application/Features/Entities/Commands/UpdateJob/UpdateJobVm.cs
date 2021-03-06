using AutoMapper;
using JobsCatalog.Application.Mapping;
using JobsCatalog.Domain.Entities;
using System.Collections.Generic;

namespace JobsCatalog.Application.Features.Entities.Commands.UpdateJob
{
    public class UpdateJobVm : IMapFrom<JobOffer>
    {
        public string PositionName { get; set; }
        public int SalaryMin { get; set; }
        public int SalaryMax { get; set; }
        public string City { get; set; }
        public int ExperienceLevelId { get; set; }
        public int CompanyId { get; set; }
        public int ProgrammingLanguageId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateJobVm, JobOffer>()
                .ForMember(x => x.Id, opt => opt.Ignore())
                .ForMember(x => x.ExperienceLevel, opt => opt.Ignore())
                .ForMember(x => x.Company, opt => opt.Ignore())
                .ForMember(x => x.ProgrammingLanguage, opt => opt.Ignore())
                .ForMember(x => x.JobDescription, opt => opt.Ignore())
                .ForMember(x => x.JobOfferTechnology, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.Created, opt => opt.Ignore())
                .ForMember(x => x.ModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.Modified, opt => opt.Ignore())
                .ForMember(x => x.StatusId, opt => opt.Ignore())
                .ForMember(x => x.InactivatedBy, opt => opt.Ignore())
                .ForMember(x => x.Inactivated, opt => opt.Ignore())
                .ForMember(x => x.VersionStamp, opt => opt.Ignore());
        }
    }
}