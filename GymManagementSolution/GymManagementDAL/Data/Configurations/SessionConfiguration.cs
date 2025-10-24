using GymManagementDAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagementDAL.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagementDAL.Data.Configurations
{
    internal class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public new void Configure(EntityTypeBuilder<Session> builder)
        {

            builder.ToTable(tb =>
            {
                tb.HasCheckConstraint("CapacityCheck", "Capacity Between 1 and 25");
                tb.HasCheckConstraint("EndDateCheck", " EndDate > StartDate");
            });

            builder.HasOne(x => x.Category)
                .WithMany(c => c.sessions)
                .HasForeignKey(x => x.CategoryId);


            builder.HasOne(x => x.Trainer)
                .WithMany(t => t.Sessions)
                .HasForeignKey(x => x.TrainerId);

            builder.Ignore(x=> x.CreatedAt);
                

        }
    }
    }

