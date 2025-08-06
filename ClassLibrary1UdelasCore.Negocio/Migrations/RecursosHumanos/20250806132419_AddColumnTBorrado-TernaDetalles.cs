using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UdelasCore.Negocio.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnTBorradoTernaDetalles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Borrado",
                table: "TernaDetalles",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Borrado",
                table: "TernaDetalles");
        }
    }
}
