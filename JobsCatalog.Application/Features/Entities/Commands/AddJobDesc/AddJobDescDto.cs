using AutoMapper;
using JobsCatalog.Application.Mapping;
using JobsCatalog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsCatalog.Application.Features.Entities.Commands.AddJobDesc
{
    public class AddJobDescDto : IMapFrom<JobDescription>
    {
        public string About { get; set; }
        public string Responsibilities { get; set; }
        public string Expectation { get; set; }
        public string Offer { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AddJobDescDto, JobDescription>()
                .ForMember(x => x.Id, opt => opt.Ignore())
                .ForMember(x => x.JobOfferId, opt => opt.Ignore())
                .ForMember(x => x.JobOffer, opt => opt.Ignore())
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