using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagementDAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GymManagementDAL.Data.Configurations
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.Property(x => x.CreatedAt)
          .HasColumnName("BookingDate")
          .HasDefaultValueSql("GETDATE()");


            builder.HasKey(x => new { x.SessionId, x.MemberId });
            builder.Ignore(x => x.Id); //to avoid id to be pk
            builder.Ignore(x => x.CreatedAt);

        }
    }
}
