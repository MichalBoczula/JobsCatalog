using AutoMapper;
using JobsCatalog.Application.Mapping;
using JobsCatalog.Domain.Entities;

namespace JobsCatalog.Application.Features.Entities.Commands.AddNewJobWholeObj
{
    public class AddJob_JobDescritpionDto : IMapFrom<JobDescription>
    {
        public string About { get; set; }
        public string Responsibilities { get; set; }
        public string Expectation { get; set; }
        public string Offer { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AddJob_JobDescritpionDto, JobDescription>()
                .ForMember(x => x.Id, opt => opt.Ignore())
                .ForMember(x => x.JobOfferId, opt => opt.Ignore())
                .ForMember(x => x.JobOffer, opt => opt.Ignore())
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.Created, opt => opt.Ignore())
                .ForMember(x => x.ModifiedBy, opt => opt.Ignore())
                .ForMember(x => x.Modified, opt => opt.Ignore())
                .ForMember(x => x.StatusId, opt => opt.Ignore())
                .ForMember(x => x.InactivatedBy, opt => opt.Ignore())
                .ForMember(x => x.Inactivated, opt => opt.Ignore());
        }
    }
}