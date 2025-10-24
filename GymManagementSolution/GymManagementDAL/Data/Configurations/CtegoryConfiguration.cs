using GymManagementDAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementDAL.Data.Configurations
{
    internal class CtegoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public new void Configure(EntityTypeBuilder<Category> builder)
        {
               
            builder.Property(x => x.Name)
                   .HasColumnType("varchar")
                 .HasMaxLength(20);

    } }
}
