using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicEsteticManagement.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class _13032023lstact2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkActivityTypes_EverydayHabit_EverydayHabitId",
                table: "WorkActivityTypes");

            migrationBuilder.DropIndex(
                name: "IX_WorkActivityTypes_EverydayHabitId",
                table: "WorkActivityTypes");

            migrationBuilder.DropColumn(
                name: "EverydayHabitId",
                table: "WorkActivityTypes");

            migrationBuilder.CreateTable(
                name: "EverydayHabitWorkActivityType",
                columns: table => new
                {
                    EverydayhabitsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkActivitysId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EverydayHabitWorkActivityType", x => new { x.EverydayhabitsId, x.WorkActivitysId });
                    table.ForeignKey(
                        name: "FK_EverydayHabitWorkActivityType_EverydayHabit_EverydayhabitsId",
                        column: x => x.EverydayhabitsId,
                        principalTable: "EverydayHabit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EverydayHabitWorkActivityType_WorkActivityTypes_WorkActivitysId",
                        column: x => x.WorkActivitysId,
                        principalTable: "WorkActivityTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EverydayHabitWorkActivityType_WorkActivitysId",
                table: "EverydayHabitWorkActivityType",
                column: "WorkActivitysId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EverydayHabitWorkActivityType");

            migrationBuilder.AddColumn<Guid>(
                name: "EverydayHabitId",
                table: "WorkActivityTypes",
                type: "uniqueidentifier",
                nullable: true);

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
    }
}
