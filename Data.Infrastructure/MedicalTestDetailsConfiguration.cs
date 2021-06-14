using Data.Models.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Infrastructure
{
    public class MedicalTestDetailsConfiguration : IEntityTypeConfiguration<MedicalTestDetail>
    {
        public void Configure(EntityTypeBuilder<MedicalTestDetail> builder)
        {
            builder.HasMany(x => x.PatientTestLogger)
                .WithOne(x => x.MedicalTestDetail)
                .HasForeignKey(x => x.MedicalTestDetailId);
        }
    }
}
