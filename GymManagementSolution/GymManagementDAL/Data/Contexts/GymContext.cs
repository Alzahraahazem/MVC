using GymManagementDAL.Data;
using GymManagementDAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementDAL.Data.Contexts
{
    public class GymContext : DbContext
    {
     
                public GymContext(DbContextOptions<GymContext> options) : base(options) { }


        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        DbSet<Member> members { get; set; }
        DbSet<Plan> plans { get; set; }
        DbSet<Trainer> trainers { get; set; }
        DbSet<Booking> Bookings { get; set; }
        DbSet<HealthRecord> HealthRecords { get; set; }
        DbSet<Session> Sessions { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<MemberShip> MemberShips { get; set; }

    }
    }
