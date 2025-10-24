using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Taller_2_Gestor.Infra.Migrations
{
    /// <inheritdoc />
    public partial class CargaDeDatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "estado_equipo",
                columns: new[] { "id_estado", "nombre" },
                values: new object[,]
                {
                    { 1, "Pendiente de revision" },
                    { 2, "Pendiente de aprobacion" },
                    { 3, "Pendiente de contacto" },
                    { 4, "Pendiente de reparacion" },
                    { 5, "Cliente contactado" },
                    { 6, "Pospuesto" },
                    { 7, "Retirado" }
                });

            migrationBuilder.InsertData(
                table: "estado_item",
                columns: new[] { "id_estado", "nombre" },
                values: new object[,]
                {
                    { 1, "Pendiente" },
                    { 2, "Aprobado" },
                    { 3, "Rechazado" },
                    { 4, "Pospuesto" },
                    { 5, "Realizado" }
                });

            migrationBuilder.InsertData(
                table: "estado_presupuesto",
                columns: new[] { "id_estado", "nombre" },
                values: new object[,]
                {
                    { 1, "Pendiente de aprobacion" },
                    { 2, "Aprobado" },
                    { 3, "Rechazado" },
                    { 4, "Realizado" },
                    { 5, "Pospuesto" }
                });

            migrationBuilder.InsertData(
                table: "marca",
                columns: new[] { "id_marca", "nombre" },
                values: new object[,]
                {
                    { 1, "Samsung" },
                    { 2, "Apple" },
                    { 3, "Dell" },
                    { 4, "HP" },
                    { 5, "Lenovo" }
                });

            migrationBuilder.InsertData(
                table: "rol",
                columns: new[] { "id_rol", "nombre_rol" },
                values: new object[,]
                {
                    { (byte)1, "Administrador" },
                    { (byte)2, "Tecnico" },
                    { (byte)3, "Administrador" }
                });

            migrationBuilder.InsertData(
                table: "servicio",
                columns: new[] { "id_servicio", "nombre_servicio" },
                values: new object[,]
                {
                    { 1, "Reparacion" },
                    { 2, "Mantenimiento" },
                    { 3, "Actualizacion Software" },
                    { 4, "Diagnostico" }
                });

            migrationBuilder.InsertData(
                table: "tipo_equipo",
                columns: new[] { "id_tipo", "nombre" },
                values: new object[,]
                {
                    { 1, "Laptop" },
                    { 2, "Desktop" },
                    { 3, "Tablet" },
                    { 4, "Smartphone" }
                });

            migrationBuilder.InsertData(
                table: "usuario",
                columns: new[] { "id_usuario", "active", "apellido", "contrasena", "id_rol", "mail", "nombre" },
                values: new object[,]
                {
                    { 1, true, "m", "m", (byte)1, "m@m.com", "m" },
                    { 2, true, "t", "t", (byte)2, "t@t.com", "t" },
                    { 3, true, "a", "a", (byte)3, "a@a.com", "a" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "estado_equipo",
                keyColumn: "id_estado",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "estado_equipo",
                keyColumn: "id_estado",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "estado_equipo",
                keyColumn: "id_estado",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "estado_equipo",
                keyColumn: "id_estado",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "estado_equipo",
                keyColumn: "id_estado",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "estado_equipo",
                keyColumn: "id_estado",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "estado_equipo",
                keyColumn: "id_estado",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "estado_item",
                keyColumn: "id_estado",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "estado_item",
                keyColumn: "id_estado",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "estado_item",
                keyColumn: "id_estado",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "estado_item",
                keyColumn: "id_estado",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "estado_item",
                keyColumn: "id_estado",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "estado_presupuesto",
                keyColumn: "id_estado",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "estado_presupuesto",
                keyColumn: "id_estado",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "estado_presupuesto",
                keyColumn: "id_estado",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "estado_presupuesto",
                keyColumn: "id_estado",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "estado_presupuesto",
                keyColumn: "id_estado",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "marca",
                keyColumn: "id_marca",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "marca",
                keyColumn: "id_marca",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "marca",
                keyColumn: "id_marca",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "marca",
                keyColumn: "id_marca",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "marca",
                keyColumn: "id_marca",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "servicio",
                keyColumn: "id_servicio",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "servicio",
                keyColumn: "id_servicio",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "servicio",
                keyColumn: "id_servicio",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "servicio",
                keyColumn: "id_servicio",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "tipo_equipo",
                keyColumn: "id_tipo",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tipo_equipo",
                keyColumn: "id_tipo",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tipo_equipo",
                keyColumn: "id_tipo",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tipo_equipo",
                keyColumn: "id_tipo",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "usuario",
                keyColumn: "id_usuario",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "usuario",
                keyColumn: "id_usuario",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "usuario",
                keyColumn: "id_usuario",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "rol",
                keyColumn: "id_rol",
                keyValue: (byte)1);

            migrationBuilder.DeleteData(
                table: "rol",
                keyColumn: "id_rol",
                keyValue: (byte)2);

            migrationBuilder.DeleteData(
                table: "rol",
                keyColumn: "id_rol",
                keyValue: (byte)3);
        }
    }
}
