using Data.Models.Patient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Data.Infrastructure
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(100);
            builder.Property(x => x.Age).HasMaxLength(3).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(256);
            builder.Property(x => x.Gender).HasMaxLength(1).IsRequired();

            builder.HasMany(x => x.EmergencyContact)
                .WithOne(x => x.Patient)
                .HasForeignKey(x => x.PatientId);

            builder.HasMany(x => x.PatientTestLogger)
                 .WithOne(x => x.Patient)
                 .HasForeignKey(x => x.PatientId);

            builder.Property(x => x.RowVersion)
                .IsConcurrencyToken();
        }
    }
}
