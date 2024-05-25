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
                    ComprasId = table.Column<int>(type: "int", nullable: false),
                    CantidadV = table.Column<int>(type: "int", nullable: false),
                    FechaV = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmpleadosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.IdVenta);
                    table.ForeignKey(
                        name: "FK_Ventas_Compras_ComprasId",
                        column: x => x.ComprasId,
                        principalTable: "Compras",
                        principalColumn: "IdProducto",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ventas_Empleados_EmpleadosId",
                        column: x => x.EmpleadosId,
                        principalTable: "Empleados",
                        principalColumn: "IdEmpleado",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_ComprasId",
                table: "Ventas",
                column: "ComprasId");

            migrationBuilder.CreateIndex(
                name: "IX_Ventas_EmpleadosId",
                table: "Ventas",
                column: "EmpleadosId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "Empleados");
        }
    }
}
