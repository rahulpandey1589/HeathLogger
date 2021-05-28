using Data.Models.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Infrastructure
{
    public class RelationShipMasterConfiguration : IEntityTypeConfiguration<RelationShipMaster>
    {
        public void Configure(EntityTypeBuilder<RelationShipMaster> builder)
        {
            builder.HasKey(x => x.RelationShipId);

            builder.Property(x => x.RelationShipName).HasMaxLength(50).IsRequired();
        }
    }
}
