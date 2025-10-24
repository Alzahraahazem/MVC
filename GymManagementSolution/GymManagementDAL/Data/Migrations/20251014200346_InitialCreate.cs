using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GymManagementDAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    photo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    weight = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    BloodType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Phone = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: true),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Address_BuildingNumber = table.Column<int>(type: "int", nullable: true),
                    Address_Street = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    Address_City = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_members", x => x.Id);
                    table.CheckConstraint("validEmail", "Email LIKE '_%@_%._%'");
                    table.CheckConstraint("validPhone", "Phone LIKE '01%'");
                });

            migrationBuilder.CreateTable(
                name: "plans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    DurationDays = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plans", x => x.Id);
                    table.CheckConstraint("PlanDuration", "DurationDays Between 1 and 365");
                });

            migrationBuilder.CreateTable(
                name: "trainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    specialties = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Phone = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: true),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Address_BuildingNumber = table.Column<int>(type: "int", nullable: true),
                    Address_Street = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    Address_City = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trainers", x => x.Id);
                    table.CheckConstraint("validEmail1", "Email LIKE '_%@_%._%'");
                    table.CheckConstraint("validPhone1", "Phone LIKE '01%'");
                });

            migrationBuilder.CreateTable(
                name: "MemberShips",
                columns: table => new
                {
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    PlanId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberShips", x => new { x.PlanId, x.MemberId });
                    table.ForeignKey(
                        name: "FK_MemberShips_members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberShips_plans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "plans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    TrainerId = table.Column<int>(type: "int", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                    table.CheckConstraint("CapacityCheck", "Capacity Between 1 and 25");
                    table.CheckConstraint("EndDateCheck", " EndDate > StartDate");
                    table.ForeignKey(
                        name: "FK_Sessions_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sessions_trainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "trainers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    SessionId = table.Column<int>(type: "int", nullable: false),
                    IsAttended = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => new { x.SessionId, x.MemberId });
                    table.ForeignKey(
                        name: "FK_Bookings_Sessions_SessionId",
                        column: x => x.SessionId,
                        principalTable: "Sessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_MemberId",
                table: "Bookings",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_members_Email",
                table: "members",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_members_Phone",
                table: "members",
                column: "Phone",
                unique: true,
                filter: "[Phone] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MemberShips_MemberId",
                table: "MemberShips",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_CategoryId",
                table: "Sessions",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_TrainerId",
                table: "Sessions",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_trainers_Email",
                table: "trainers",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_trainers_Phone",
                table: "trainers",
                column: "Phone",
                unique: true,
                filter: "[Phone] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "MemberShips");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "members");

            migrationBuilder.DropTable(
                name: "plans");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "trainers");
        }
    }
}
