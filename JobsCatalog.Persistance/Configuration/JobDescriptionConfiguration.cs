using JobsCatalog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsCatalog.Persistance.Configuration
{
    public class JobDescriptionConfiguration : IEntityTypeConfiguration<JobDescription>
    {
        public void Configure(EntityTypeBuilder<JobDescription> builder)
        {
            builder.HasKey(k => k.Id);
            builder.HasIndex(x => x.JobOfferId).IsUnique();
        }
    }
}
