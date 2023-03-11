using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinicEsteticManagement.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PregnancyTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PregnancyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GynecologicalConditions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PregnantDate = table.Column<DateTime>(type: "Date", nullable: false),
                    PregnancyTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BreastFeedDate = table.Column<DateTime>(type: "Date", nullable: false),
                    MenstruatingDate = table.Column<DateTime>(type: "Date", nullable: false),
                    MenopauseDate = table.Column<DateTime>(type: "Date", nullable: false),
                    ChildrenQuantity = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GynecologicalConditions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GynecologicalConditions_PregnancyTypes_PregnancyTypeId",
                        column: x => x.PregnancyTypeId,
                        principalTable: "PregnancyTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ClinicalInformations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsLeftHanded = table.Column<bool>(type: "bit", nullable: false),
                    MentalState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClinicalBackground = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alergies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Medicines = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxBloodPressure = table.Column<int>(type: "int", nullable: false),
                    MinBloodPressure = table.Column<int>(type: "int", nullable: false),
                    HearRate = table.Column<int>(type: "int", nullable: false),
                    HasRadioactiveDevices = table.Column<bool>(type: "bit", nullable: false),
                    HasProteses = table.Column<bool>(type: "bit", nullable: false),
                    HasPacemaker = table.Column<bool>(type: "bit", nullable: false),
                    HasImplants = table.Column<bool>(type: "bit", nullable: false),
                    HasIntraUterineDevice = table.Column<bool>(type: "bit", nullable: false),
                    AgainstIndications = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surgeries = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GynecologicalConditionsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClinicalInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClinicalInformations_GynecologicalConditions_GynecologicalConditionsId",
                        column: x => x.GynecologicalConditionsId,
                        principalTable: "GynecologicalConditions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "Date", nullable: false),
                    JobOccupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observations = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClinicalInformationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_ClinicalInformations_ClinicalInformationId",
                        column: x => x.ClinicalInformationId,
                        principalTable: "ClinicalInformations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ClinicalInformationId",
                table: "Clients",
                column: "ClinicalInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_ClinicalInformations_GynecologicalConditionsId",
                table: "ClinicalInformations",
                column: "GynecologicalConditionsId");

            migrationBuilder.CreateIndex(
                name: "IX_GynecologicalConditions_PregnancyTypeId",
                table: "GynecologicalConditions",
                column: "PregnancyTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "ClinicalInformations");

            migrationBuilder.DropTable(
                name: "GynecologicalConditions");

            migrationBuilder.DropTable(
                name: "PregnancyTypes");
        }
    }
}
