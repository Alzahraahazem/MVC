using GymManagementDAL.Data.Contexts;
using GymManagementDAL.Data.Reposetries.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace GymManagementPL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // 1.  ”ÃÌ· DbContext
            builder.Services.AddDbContext<GymContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


            // 2.  ”ÃÌ· «·‹ Repository
            builder.Services.AddScoped<IMemberRepository, IMemberRepository>();

            // 3.  ”ÃÌ· «·‹ Service
           // builder.Services.AddScoped<MemberService>();

            // 4.  ”ÃÌ· «·‹ Controllers Ê Views
           // builder.Services.AddControllersWithViews();


            var app = builder.Build();

            // »«ﬁÌ «·≈⁄œ«œ« ...
            app.MapDefaultControllerRoute();
            app.Run();

        }
    }
}
