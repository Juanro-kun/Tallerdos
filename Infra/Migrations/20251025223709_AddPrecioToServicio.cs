using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taller_2_Gestor.Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddPrecioToServicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "precio",
                table: "servicio",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.UpdateData(
                table: "servicio",
                keyColumn: "id_servicio",
                keyValue: 1,
                column: "precio",
                value: 1000f);

            migrationBuilder.UpdateData(
                table: "servicio",
                keyColumn: "id_servicio",
                keyValue: 2,
                column: "precio",
                value: 1000f);

            migrationBuilder.UpdateData(
                table: "servicio",
                keyColumn: "id_servicio",
                keyValue: 3,
                column: "precio",
                value: 1000f);

            migrationBuilder.UpdateData(
                table: "servicio",
                keyColumn: "id_servicio",
                keyValue: 4,
                column: "precio",
                value: 1000f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "precio",
                table: "servicio");
        }
    }
}
