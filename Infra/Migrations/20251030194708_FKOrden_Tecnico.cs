using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taller_2_Gestor.Infra.Migrations
{
    /// <inheritdoc />
    public partial class FKOrden_Tecnico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdTecnico",
                table: "orden_servicio",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_orden_servicio_IdTecnico",
                table: "orden_servicio",
                column: "IdTecnico");

            migrationBuilder.AddForeignKey(
                name: "FK_orden_servicio_tecnico",
                table: "orden_servicio",
                column: "IdTecnico",
                principalTable: "usuario",
                principalColumn: "id_usuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orden_servicio_tecnico",
                table: "orden_servicio");

            migrationBuilder.DropIndex(
                name: "IX_orden_servicio_IdTecnico",
                table: "orden_servicio");

            migrationBuilder.DropColumn(
                name: "IdTecnico",
                table: "orden_servicio");
        }
    }
}
