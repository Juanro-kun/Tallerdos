using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taller_2_Gestor.Infra.Migrations
{
    /// <inheritdoc />
    public partial class FKComentario_Tecnico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TecnicoId",
                table: "comentario",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_comentario_TecnicoId",
                table: "comentario",
                column: "TecnicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_comentario_tecnico",
                table: "comentario",
                column: "TecnicoId",
                principalTable: "usuario",
                principalColumn: "id_usuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comentario_tecnico",
                table: "comentario");

            migrationBuilder.DropIndex(
                name: "IX_comentario_TecnicoId",
                table: "comentario");

            migrationBuilder.DropColumn(
                name: "TecnicoId",
                table: "comentario");
        }
    }
}
