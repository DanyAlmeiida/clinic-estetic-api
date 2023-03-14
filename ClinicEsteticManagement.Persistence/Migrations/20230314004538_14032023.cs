using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicEsteticManagement.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class _14032023 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EverydayHabitWorkActivityType_EverydayHabit_EverydayhabitsId",
                table: "EverydayHabitWorkActivityType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EverydayHabit",
                table: "EverydayHabit");

            migrationBuilder.RenameTable(
                name: "EverydayHabit",
                newName: "EverydayHabits");

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId",
                table: "EverydayHabits",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_EverydayHabits",
                table: "EverydayHabits",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_EverydayHabits_ClientId",
                table: "EverydayHabits",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_EverydayHabits_Clients_ClientId",
                table: "EverydayHabits",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EverydayHabitWorkActivityType_EverydayHabits_EverydayhabitsId",
                table: "EverydayHabitWorkActivityType",
                column: "EverydayhabitsId",
                principalTable: "EverydayHabits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EverydayHabits_Clients_ClientId",
                table: "EverydayHabits");

            migrationBuilder.DropForeignKey(
                name: "FK_EverydayHabitWorkActivityType_EverydayHabits_EverydayhabitsId",
                table: "EverydayHabitWorkActivityType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EverydayHabits",
                table: "EverydayHabits");

            migrationBuilder.DropIndex(
                name: "IX_EverydayHabits_ClientId",
                table: "EverydayHabits");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "EverydayHabits");

            migrationBuilder.RenameTable(
                name: "EverydayHabits",
                newName: "EverydayHabit");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EverydayHabit",
                table: "EverydayHabit",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EverydayHabitWorkActivityType_EverydayHabit_EverydayhabitsId",
                table: "EverydayHabitWorkActivityType",
                column: "EverydayhabitsId",
                principalTable: "EverydayHabit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
