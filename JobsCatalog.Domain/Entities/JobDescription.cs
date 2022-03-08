﻿using JobsCatalog.Domain.Common;

namespace JobsCatalog.Domain.Entities
{
    public class JobDescription : AuditableEntity
    {
        public string About { get; set; }
        public string Responsibilities { get; set; }
        public string Expectation { get; set; }
        public string Offer { get; set; }
        public int JobOfferId { get; set; }
        public JobOffer JobOffer{ get; set; }
    }
}
