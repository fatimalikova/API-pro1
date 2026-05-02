using EventManagementAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api_Pro1.Configurations
{
    public class OrganizerConfiguration : IEntityTypeConfiguration<Organizer>
    {
        public void Configure(EntityTypeBuilder<Organizer> builder)
        {
            builder.HasKey(o => o.OrganizerId);
            builder.Property(o => o.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(o => o.Email)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(o => o.Phone)
                .IsRequired()
                .HasMaxLength(100);
                builder.Property(o => o.LogoUrl)
                .IsRequired()
                .HasMaxLength(100);

        }
    }
}
