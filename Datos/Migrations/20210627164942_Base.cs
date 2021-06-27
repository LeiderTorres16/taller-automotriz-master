using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class Base : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Detalles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Servicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorUnitario = table.Column<double>(type: "float", nullable: false),
                    Cliente_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    clienteIdentificacion = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ServicioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Detalles_Clientes_clienteIdentificacion",
                        column: x => x.clienteIdentificacion,
                        principalTable: "Clientes",
                        principalColumn: "Identificacion",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Detalles_Servicios_ServicioId",
                        column: x => x.ServicioId,
                        principalTable: "Servicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobilePhone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserName);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_clienteIdentificacion",
                table: "Detalles",
                column: "clienteIdentificacion");

            migrationBuilder.CreateIndex(
                name: "IX_Detalles_ServicioId",
                table: "Detalles",
                column: "ServicioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detalles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
