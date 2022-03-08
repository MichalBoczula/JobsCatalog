using JobsCatalog.Domain.Helper;
using System.Collections.Generic;

namespace JobsCatalog.Domain.Dictionaries
{
    public class Technology
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<JobOfferTechnology> JobOfferTechnology { get; set; }
    }
}
