using JobsCatalog.Domain.Entities;
using System.Collections.Generic;

namespace JobsCatalog.Domain.Dictionaries
{
    public class ProgrammingLanguage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public ICollection<JobOffer> JobOffers { get; set; }
    }
}
