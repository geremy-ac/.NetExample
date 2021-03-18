using Microsoft.EntityFrameworkCore.Migrations;

namespace NETCORE_CRUD_991.Migrations
{
    public partial class Primera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CargoEmpleados",
                columns: table => new
                {
                    IdCargo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cargo = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoEmpleados", x => x.IdCargo);
                });

            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCliente = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Correo = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "empleados",
                columns: table => new
                {
                    IdEmpleado = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEmpleado = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Documento = table.Column<int>(nullable: false),
                    Cargo = table.Column<int>(nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empleados", x => x.IdEmpleado);
                });

            migrationBuilder.CreateTable(
                name: "paquetes",
                columns: table => new
                {
                    IdPaquete = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoPaquete = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PesoLibra = table.Column<float>(nullable: false),
                    IdCliente = table.Column<int>(nullable: false),
                    IdValorLibra = table.Column<int>(nullable: false),
                    Estado = table.Column<string>(nullable: true),
                    USA = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    IdTransportadora = table.Column<int>(nullable: false),
                    IdTipoMercancia = table.Column<int>(nullable: false),
                    COL = table.Column<int>(nullable: false),
                    ValorPagar = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paquetes", x => x.IdPaquete);
                });

            migrationBuilder.CreateTable(
                name: "tipomercancias",
                columns: table => new
                {
                    IdTipoMercancia = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTipoMercancia = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipomercancias", x => x.IdTipoMercancia);
                });

            migrationBuilder.CreateTable(
                name: "transportadoras",
                columns: table => new
                {
                    IdTransportadora = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreTransportadora = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transportadoras", x => x.IdTransportadora);
                });

            migrationBuilder.CreateTable(
                name: "valorlibra",
                columns: table => new
                {
                    IdValorLibra = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_valorlibra", x => x.IdValorLibra);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CargoEmpleados");

            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "empleados");

            migrationBuilder.DropTable(
                name: "paquetes");

            migrationBuilder.DropTable(
                name: "tipomercancias");

            migrationBuilder.DropTable(
                name: "transportadoras");

            migrationBuilder.DropTable(
                name: "valorlibra");
        }
    }
}
