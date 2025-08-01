using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Udelascore.IdentityManager.Entidades.Mapping
{
    public class AspNetMembershipMap : IEntityTypeConfiguration<AspNetMembership>
    {
        public void Configure(EntityTypeBuilder<AspNetMembership> entity)
        {
            entity.ToTable("AspNetMemberships");
            entity.HasKey(e => e.Id)
                .HasName("PK_Membership");

            entity.Property(e => e.UserId)
                .IsRequired()
                .HasMaxLength(450);
            entity.Property(e => e.PasswordHash)
                .HasColumnType("nvarchar(max)");
            entity.Property(e => e.Observacion)
                .HasColumnType("nvarchar(max)");

        }
    }
}
