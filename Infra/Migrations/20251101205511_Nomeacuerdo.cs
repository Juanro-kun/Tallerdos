using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taller_2_Gestor.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Nomeacuerdo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "fecha",
                table: "comentario",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldDefaultValueSql: "(getdate())");

            migrationBuilder.InsertData(
                table: "estado_presupuesto",
                columns: new[] { "id_estado", "nombre" },
                values: new object[] { 6, "Consultar Cliente" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "estado_presupuesto",
                keyColumn: "id_estado",
                keyValue: 6);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "fecha",
                table: "comentario",
                type: "date",
                nullable: false,
                defaultValueSql: "(getdate())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "(getdate())");
        }
    }
}
