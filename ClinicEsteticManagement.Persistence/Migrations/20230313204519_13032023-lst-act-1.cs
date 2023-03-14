using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicEsteticManagement.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class _13032023lstact1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "EverydayHabitId",
                table: "WorkActivityTypes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "EverydayHabit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Smoke = table.Column<bool>(type: "bit", nullable: false),
                    Drinks = table.Column<bool>(type: "bit", nullable: false),
                    Feeding = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SleepQuality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WaterIntakePerDay = table.Column<float>(type: "real", nullable: false),
                    WorkFunction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoesPhysicalActivity = table.Column<bool>(type: "bit", nullable: false),
                    PhysicalActivity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeADayOfPhysicalActivty = table.Column<TimeSpan>(type: "time", nullable: true),
                    TimeADayWithoutPhysicalActivty = table.Column<TimeSpan>(type: "time", nullable: true),
                    PainSensitive = table.Column<bool>(type: "bit", nullable: false),
                    HairRemovalMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EverydayHabit", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkActivityTypes_EverydayHabitId",
                table: "WorkActivityTypes",
                column: "EverydayHabitId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkActivityTypes_EverydayHabit_EverydayHabitId",
                table: "WorkActivityTypes",
                column: "EverydayHabitId",
                principalTable: "EverydayHabit",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkActivityTypes_EverydayHabit_EverydayHabitId",
                table: "WorkActivityTypes");

            migrationBuilder.DropTable(
                name: "EverydayHabit");

            migrationBuilder.DropIndex(
                name: "IX_WorkActivityTypes_EverydayHabitId",
                table: "WorkActivityTypes");

            migrationBuilder.DropColumn(
                name: "EverydayHabitId",
                table: "WorkActivityTypes");
        }
    }
}
