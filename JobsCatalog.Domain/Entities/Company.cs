using JobsCatalog.Domain.Common;
using System.Collections.Generic;

namespace JobsCatalog.Domain.Entities
{
    public class Company : AuditableEntity
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string CompanyLogo { get; set; }
        public ICollection<JobOffer> JobOffers { get; set; }
    }
}
