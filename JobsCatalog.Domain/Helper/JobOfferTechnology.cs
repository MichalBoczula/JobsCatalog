﻿using JobsCatalog.Domain.Dictionaries;
using JobsCatalog.Domain.Entities;

namespace JobsCatalog.Domain.Helper
{
    public class JobOfferTechnology
    {
        public int JobOfferId { get; set; }
        public JobOffer JobOffer { get; set; }
        public int TechnologyId { get; set; }
        public Technology Technology { get; set; }
    }
}
 