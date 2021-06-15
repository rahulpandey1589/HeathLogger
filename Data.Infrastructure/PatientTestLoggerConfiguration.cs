using Data.Models.Patient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Data.Infrastructure
{
    public class PatientTestLoggerConfiguration : IEntityTypeConfiguration<PatientTestLogger>
    {
        public void Configure(EntityTypeBuilder<PatientTestLogger> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TestValue).IsRequired().HasMaxLength(10);
            builder.Property(x => x.IsDeleted).IsRequired();

           
        }
    }
}
