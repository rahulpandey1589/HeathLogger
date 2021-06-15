using Data.Models.Patient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Infrastructure
{
    public class PatientEmergencyContactDetailsConfiguration : IEntityTypeConfiguration<EmergencyContactDetails>
    {
        public void Configure(EntityTypeBuilder<EmergencyContactDetails> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(100);
            builder.Property(x => x.ContactNumber).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(256);
            builder.HasOne(x => x.RelationShip)
                   .WithOne(x => x.PatientEmergency)
                   .HasForeignKey<EmergencyContactDetails>(x => x.RelationShipId);
            builder.HasOne(x => x.EmergencyContactDetailAddress)
                   .WithOne(x => x.PatientEmergency)
                   .HasForeignKey<EmergencyContactDetails>(x => x.AddressId);

        }
    }
}
