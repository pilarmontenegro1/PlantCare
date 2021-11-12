using Microsoft.EntityFrameworkCore.Migrations;

namespace MiJardin.Migrations
{
    public partial class AddModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plant",
                columns: table => new
                {
                    PlantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Especie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Iluminacion = table.Column<int>(type: "int", nullable: false),
                    Riego = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fertilizacion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plant", x => x.PlantID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plant");
        }
    }
}
