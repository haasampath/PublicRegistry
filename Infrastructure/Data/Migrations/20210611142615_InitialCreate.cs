using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Observations",
                columns: table => new
                {
                    ObservationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimalID = table.Column<int>(type: "int", nullable: false),
                    NoHunters = table.Column<int>(type: "int", nullable: false),
                    NoHours = table.Column<int>(type: "int", nullable: false),
                    NoMale = table.Column<int>(type: "int", nullable: false),
                    NoFemale = table.Column<int>(type: "int", nullable: false),
                    NoFemale1Calf = table.Column<int>(type: "int", nullable: false),
                    NoFemale2Calf = table.Column<int>(type: "int", nullable: false),
                    NoElder = table.Column<int>(type: "int", nullable: false),
                    NoCalf = table.Column<int>(type: "int", nullable: false),
                    NoUnknown = table.Column<int>(type: "int", nullable: false),
                    HuntingFieldID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsCultivateLand = table.Column<bool>(type: "bit", nullable: true),
                    ExporterName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExporterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Observations", x => x.ObservationID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Observations");
        }
    }
}
