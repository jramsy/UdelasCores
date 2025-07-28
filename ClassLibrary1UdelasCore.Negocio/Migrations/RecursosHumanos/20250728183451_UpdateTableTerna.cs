using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UdelasCore.Negocio.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableTerna : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ternas_Estado_EstadoIdEstado",
                table: "Ternas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estado",
                table: "Estado");

            migrationBuilder.DropColumn(
                name: "IdFacultad",
                table: "Ternas");

            migrationBuilder.RenameTable(
                name: "Estado",
                newName: "Estados");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "Ternas",
                newName: "CodMateria");

            migrationBuilder.RenameColumn(
                name: "IdSemestre",
                table: "Ternas",
                newName: "Anio");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estados",
                table: "Estados",
                column: "IdEstado");

            migrationBuilder.AddForeignKey(
                name: "FK_Ternas_Estados_EstadoIdEstado",
                table: "Ternas",
                column: "EstadoIdEstado",
                principalTable: "Estados",
                principalColumn: "IdEstado",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ternas_Estados_EstadoIdEstado",
                table: "Ternas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estados",
                table: "Estados");

            migrationBuilder.RenameTable(
                name: "Estados",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "CodMateria",
                table: "Ternas",
                newName: "Year");

            migrationBuilder.RenameColumn(
                name: "Anio",
                table: "Ternas",
                newName: "IdSemestre");

            migrationBuilder.AddColumn<int>(
                name: "IdFacultad",
                table: "Ternas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estado",
                table: "Estado",
                column: "IdEstado");

            migrationBuilder.AddForeignKey(
                name: "FK_Ternas_Estado_EstadoIdEstado",
                table: "Ternas",
                column: "EstadoIdEstado",
                principalTable: "Estado",
                principalColumn: "IdEstado",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

//FACULTADES, CARRERAS, MATERIAS_POR_CARRERA