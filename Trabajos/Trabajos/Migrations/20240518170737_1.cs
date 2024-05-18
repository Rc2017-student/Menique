using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trabajos.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    IdProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PrecioC = table.Column<int>(type: "int", nullable: false),
                    CantidadC = table.Column<int>(type: "int", nullable: false),
                    FechaC = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.IdProducto);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    IdEmpleado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ApellidoE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PuestoE = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaContratacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Salario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.IdEmpleado);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    IdVenta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductoV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrecioV = table.Column<int>(type: "int", nullable: false),
                    CantidadV = table.Column<int>(type: "int", nullable: false),
                    FechaV = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmpleadoV = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.IdVenta);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Ventas");
        }
    }
}
