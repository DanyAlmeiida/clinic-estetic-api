using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicEsteticManagement.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EverydayHabitsNullables1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "WaterIntakePerDay",
                table: "EverydayHabits",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "WaterIntakePerDay",
                table: "EverydayHabits",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);
        }
    }
}
