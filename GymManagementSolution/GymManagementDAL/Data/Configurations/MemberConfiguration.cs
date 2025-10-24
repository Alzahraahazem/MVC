using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagementDAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace GymManagementDAL.Data.Configurations
{
    internal class MemberConfiguration :GymUserConfiguration<Member>,  IEntityTypeConfiguration<Member>
    {
       public new void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(x => x.CreatedAt).HasColumnName("JoinDate")
                .HasDefaultValueSql("GETDATE()");

            base.Configure(builder);

            builder.Ignore(x => x.CreatedAt);

        }
    }
}
