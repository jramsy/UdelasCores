using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UdelasCore.Negocio.Migrations
{
    /// <inheritdoc />
    public partial class CedulaenTernaDetalle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdDocente",
                table: "TernaDetalles",
                newName: "CedDocente");

            // Cambiar tipo a VARCHAR(13)
            migrationBuilder.AlterColumn<string>(
                name: "CedDocente",
                table: "TernaDetalles",
                type: "varchar(13)", // especificar tipo exacto en SQL Server
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Volver a tipo anterior (nvarchar(max))
            migrationBuilder.AlterColumn<string>(
                name: "CedDocente",
                table: "TernaDetalles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(13)",
                oldMaxLength: 13);

            // Volver al nombre anterior
            migrationBuilder.RenameColumn(
                name: "CedDocente",
                table: "TernaDetalles",
                newName: "IdDocente");
        }
    }
}
