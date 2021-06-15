using Data.Models.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Infrastructure
{
    public class MedicalTestMasterConfiguration : IEntityTypeConfiguration<MedicalTestMaster>
    {
        public void Configure(EntityTypeBuilder<MedicalTestMaster> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.TestName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();

            builder.HasMany(x => x.MedicalTestDetails)
                .WithOne(x => x.MedicalTestMaster)
                .HasForeignKey(x => x.TestMasterId);
        }
    }
}
