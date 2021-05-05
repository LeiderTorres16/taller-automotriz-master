using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class citas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlacaVehiculo",
                table: "Citas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PlacaVehiculo",
                table: "Citas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
