using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagementDAL.Entities;

namespace GymManagementDAL.Data.Configurations
{
    internal class HealthRecordConfiguration : IEntityTypeConfiguration<HealthRecord>
    {
        public void Configure(EntityTypeBuilder<HealthRecord> builder)
        {
            builder.ToTable("members");

            builder.HasOne(hr => hr.Member)
            .WithOne(m => m.HealthRecord)
            .HasForeignKey<HealthRecord>(hr => hr.Id)
            .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.Height).HasPrecision(18, 2);
            builder.Property(x => x.weight).HasPrecision(18, 2);


        }
    }
}
