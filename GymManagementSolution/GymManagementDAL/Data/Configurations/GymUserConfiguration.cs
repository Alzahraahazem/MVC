using GymManagementDAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagementDAL.Data.Configurations
{
    internal class GymUserConfiguration<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.Name)
                .HasColumnType("varchar")
                .HasMaxLength(50);

            builder.Property(x => x.Email)
                .HasColumnType("varchar")
                .HasMaxLength(100);

            builder.Property(x => x.Phone)
                .HasColumnType("varchar")
                .HasMaxLength(11);

            builder.ToTable(tb =>
            {
                tb.HasCheckConstraint("validEmail", "Email LIKE '_%@_%._%'");
                tb.HasCheckConstraint("validPhone", "Phone LIKE '01%'");
            });

            builder.HasIndex(x => x.Email).IsUnique();
            builder.HasIndex(x => x.Phone).IsUnique();

            builder.OwnsOne(x => x.Address, address =>
            {
                address.Property(a => a.Street)
                    .HasColumnType("varchar")
                    .HasMaxLength(30);

                address.Property(a => a.City)
                    .HasColumnType("varchar")
                    .HasMaxLength(30);
            });
        }
    }
}
