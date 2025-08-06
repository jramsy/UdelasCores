using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UdelasCore.Negocio.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnBorradoTerna : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AlterColumn<int>(
                name: "EstadoIdEstado",
                table: "Ternas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Borrado",
                table: "Ternas",
                type: "bit",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TernaDetalles_IdEstado",
                table: "TernaDetalles",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_TernaDetalles_IdTerna",
                table: "TernaDetalles",
                column: "IdTerna");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropForeignKey(
                name: "FK_TernaDetalles_Ternas_IdTerna",
                table: "TernaDetalles");

            migrationBuilder.DropForeignKey(
                name: "FK_Ternas_Estados_EstadoIdEstado",
                table: "Ternas");

            migrationBuilder.DropIndex(
                name: "IX_TernaDetalles_IdEstado",
                table: "TernaDetalles");

            migrationBuilder.DropIndex(
                name: "IX_TernaDetalles_IdTerna",
                table: "TernaDetalles");

            migrationBuilder.DropColumn(
                name: "Borrado",
                table: "Ternas");

            migrationBuilder.AlterColumn<int>(
                name: "EstadoIdEstado",
                table: "Ternas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "EstadoIdEstado",
                table: "TernaDetalles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TernaIdTerna",
                table: "TernaDetalles",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Estados",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_TernaDetalles_EstadoIdEstado",
                table: "TernaDetalles",
                column: "EstadoIdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_TernaDetalles_TernaIdTerna",
                table: "TernaDetalles",
                column: "TernaIdTerna");

            migrationBuilder.AddForeignKey(
                name: "FK_TernaDetalles_Estados_EstadoIdEstado",
                table: "TernaDetalles",
                column: "EstadoIdEstado",
                principalTable: "Estados",
                principalColumn: "IdEstado");

            migrationBuilder.AddForeignKey(
                name: "FK_TernaDetalles_Ternas_TernaIdTerna",
                table: "TernaDetalles",
                column: "TernaIdTerna",
                principalTable: "Ternas",
                principalColumn: "IdTerna");

            migrationBuilder.AddForeignKey(
                name: "FK_Ternas_Estados_EstadoIdEstado",
                table: "Ternas",
                column: "EstadoIdEstado",
                principalTable: "Estados",
                principalColumn: "IdEstado");
        }
    }
}
