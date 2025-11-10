using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taller_2_Gestor.Infra.Migrations
{
    /// <inheritdoc />
    public partial class DateOnlyToDateTimeFechaOrdenServicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "fecha",
                table: "orden_servicio",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "date");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "fecha",
                table: "orden_servicio",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
