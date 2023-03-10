using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicEsteticManagement.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class generalDiseases : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_ClinicalInformations_ClinicalInformationId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_ClinicalInformationId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "ClinicalInformationId",
                table: "Clients");

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId",
                table: "ClinicalInformations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GeneralDiseases",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiabetesDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiabetesType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CholesterolDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CholesterolValue = table.Column<double>(type: "float", nullable: false),
                    TriglyceridesDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TriglyceridesValue = table.Column<double>(type: "float", nullable: false),
                    HasVascularProblems = table.Column<bool>(type: "bit", nullable: false),
                    HasChilblains = table.Column<bool>(type: "bit", nullable: false),
                    HasEpilepsy = table.Column<bool>(type: "bit", nullable: false),
                    HasSkinProblems = table.Column<bool>(type: "bit", nullable: false),
                    HasHypotension = table.Column<bool>(type: "bit", nullable: false),
                    HasHyperthyroidism = table.Column<bool>(type: "bit", nullable: false),
                    HasHemophiliac = table.Column<bool>(type: "bit", nullable: false),
                    FoodIntolerance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CancerBackground = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StressDegree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Intestine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralDiseases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeneralDiseases_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClinicalInformations_ClientId",
                table: "ClinicalInformations",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralDiseases_ClientId",
                table: "GeneralDiseases",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClinicalInformations_Clients_ClientId",
                table: "ClinicalInformations",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClinicalInformations_Clients_ClientId",
                table: "ClinicalInformations");

            migrationBuilder.DropTable(
                name: "GeneralDiseases");

            migrationBuilder.DropIndex(
                name: "IX_ClinicalInformations_ClientId",
                table: "ClinicalInformations");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "ClinicalInformations");

            migrationBuilder.AddColumn<Guid>(
                name: "ClinicalInformationId",
                table: "Clients",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ClinicalInformationId",
                table: "Clients",
                column: "ClinicalInformationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_ClinicalInformations_ClinicalInformationId",
                table: "Clients",
                column: "ClinicalInformationId",
                principalTable: "ClinicalInformations",
                principalColumn: "Id");
        }
    }
}
