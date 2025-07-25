using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UdelasCore.Negocio.Migrations
{
    /// <inheritdoc />
    public partial class TernaCreateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    IdEstado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.IdEstado);
                });

            migrationBuilder.CreateTable(
                name: "TernaDetalles",
                columns: table => new
                {
                    IdTernaDetalle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTerna = table.Column<int>(type: "int", nullable: false),
                    IdEstado = table.Column<int>(type: "int", nullable: false),
                    IdDocente = table.Column<int>(type: "int", nullable: false),
                    IdUsuarioCreador = table.Column<int>(type: "int", nullable: false),
                    IdUsuarioModificador = table.Column<int>(type: "int", nullable: false),
                    IdUsuarioBorrador = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaBorrador = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TernaDetalles", x => x.IdTernaDetalle);
                });

            migrationBuilder.CreateTable(
                name: "Ternas",
                columns: table => new
                {
                    IdTerna = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    IdFacultad = table.Column<int>(type: "int", nullable: false),
                    IdSemestre = table.Column<int>(type: "int", nullable: false),
                    CodCarrera = table.Column<int>(type: "int", nullable: false),
                    FechaInicio = table.Column<DateOnly>(type: "date", nullable: false),
                    FechaFinal = table.Column<DateOnly>(type: "date", nullable: false),
                    IdUsuarioCreador = table.Column<int>(type: "int", nullable: false),
                    IdUsuarioModificador = table.Column<int>(type: "int", nullable: false),
                    IdUsuarioBorrador = table.Column<int>(type: "int", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaModificacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaBorrador = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstadoIdEstado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ternas", x => x.IdTerna);
                    table.ForeignKey(
                        name: "FK_Ternas_Estado_EstadoIdEstado",
                        column: x => x.EstadoIdEstado,
                        principalTable: "Estado",
                        principalColumn: "IdEstado",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ternas_EstadoIdEstado",
                table: "Ternas",
                column: "EstadoIdEstado");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TernaDetalles");

            migrationBuilder.DropTable(
                name: "Ternas");

            migrationBuilder.DropTable(
                name: "Estado");
        }
    }
}
