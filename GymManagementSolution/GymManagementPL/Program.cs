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

            // 1. ����� DbContext
            builder.Services.AddDbContext<GymContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


            // 2. ����� ��� Repository
            builder.Services.AddScoped<IMemberRepository, IMemberRepository>();

            // 3. ����� ��� Service
           // builder.Services.AddScoped<MemberService>();

            // 4. ����� ��� Controllers � Views
           // builder.Services.AddControllersWithViews();


            var app = builder.Build();

            // ���� ���������...
            app.MapDefaultControllerRoute();
            app.Run();

        }
    }
}
