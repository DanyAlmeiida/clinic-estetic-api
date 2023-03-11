using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicEsteticManagement.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class clientrelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClinicalInformations_Clients_ClientId",
                table: "ClinicalInformations");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "ClinicalInformations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ClinicalInformations_Clients_ClientId",
                table: "ClinicalInformations",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClinicalInformations_Clients_ClientId",
                table: "ClinicalInformations");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "ClinicalInformations",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_ClinicalInformations_Clients_ClientId",
                table: "ClinicalInformations",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id");
        }
    }
}
