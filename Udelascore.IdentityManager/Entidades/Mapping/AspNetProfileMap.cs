using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Udelascore.IdentityManager.Entidades.Mapping
{
    public class AspNetProfileMap : IEntityTypeConfiguration<AspNetProfile>
    {
        public void Configure(EntityTypeBuilder<AspNetProfile> entity)
        {
            entity.ToTable("AspNetProfiles");
            entity.HasKey(e => e.UserId)
                .HasName("PK_AspNetProfiles");

            entity.Property(e => e.UserId)
                .IsRequired()
                .HasMaxLength(450);
            entity.Property(e => e.ProfileImage)
                .IsRequired()
                .HasColumnType("image");
            entity.Property(e => e.LastUpdatedDate)
                .HasColumnType("datetime");
        }
    }
}
