using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Udelascore.IdentityManager.Entidades.Mapping
{
    public class AspNetApplicationMap : IEntityTypeConfiguration<AspNetApplication>
    {
        public void Configure(EntityTypeBuilder<AspNetApplication> entity)
        {
            entity.ToTable("AspNetApplications");
            entity.HasKey(e => e.ApplicationId)
                .HasName("PK_Application");
            entity.Property(e => e.ApplicationId)
                .IsRequired()
                .HasMaxLength(256);
            entity.Property(e => e.ApplicationName)
                .IsRequired()
                .HasMaxLength(256);
            entity.Property(e => e.LoweredApplicationName)
                .IsRequired()
                .HasMaxLength(256);
            entity.Property(e => e.Description)
                .HasDefaultValue(string.Empty)
                .HasMaxLength(256);
        }
    }
}
