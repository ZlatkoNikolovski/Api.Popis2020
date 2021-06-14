using Microsoft.EntityFrameworkCore.Migrations;

namespace Application.Migrations
{
    public partial class DodadeniZhiteli : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Zhiteli",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Maticen = table.Column<int>(type: "int", nullable: false),
                    Godini = table.Column<int>(type: "int", nullable: false),
                    OpstinaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zhiteli", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zhiteli_Opstina_OpstinaId",
                        column: x => x.OpstinaId,
                        principalTable: "Opstina",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zhiteli_OpstinaId",
                table: "Zhiteli",
                column: "OpstinaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Zhiteli");
        }
    }
}
