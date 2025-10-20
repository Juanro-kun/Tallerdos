using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taller_2_Gestor.Infra.Migrations
{
    /// <inheritdoc />
    public partial class InitialStructure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    id_cliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    apellido = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    mail = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    telefono = table.Column<long>(type: "bigint", nullable: false),
                    dni = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.id_cliente);
                });

            migrationBuilder.CreateTable(
                name: "estado_equipo",
                columns: table => new
                {
                    id_estado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estado_equipo", x => x.id_estado);
                });

            migrationBuilder.CreateTable(
                name: "estado_item",
                columns: table => new
                {
                    id_estado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estado_item", x => x.id_estado);
                });

            migrationBuilder.CreateTable(
                name: "estado_presupuesto",
                columns: table => new
                {
                    id_estado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estado_presupuesto", x => x.id_estado);
                });

            migrationBuilder.CreateTable(
                name: "marca",
                columns: table => new
                {
                    id_marca = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marca", x => x.id_marca);
                });

            migrationBuilder.CreateTable(
                name: "rol",
                columns: table => new
                {
                    id_rol = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_rol = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rol", x => x.id_rol);
                });

            migrationBuilder.CreateTable(
                name: "servicio",
                columns: table => new
                {
                    id_servicio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_servicio = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_servicio", x => x.id_servicio);
                });

            migrationBuilder.CreateTable(
                name: "tipo_equipo",
                columns: table => new
                {
                    id_tipo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipo_equipo", x => x.id_tipo);
                });

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    id_usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    apellido = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    mail = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    contrasena = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    active = table.Column<bool>(type: "bit", nullable: false),
                    id_rol = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.id_usuario);
                    table.ForeignKey(
                        name: "FK_usuario_rol",
                        column: x => x.id_rol,
                        principalTable: "rol",
                        principalColumn: "id_rol");
                });

            migrationBuilder.CreateTable(
                name: "equipo",
                columns: table => new
                {
                    id_equipo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false),
                    id_marca = table.Column<int>(type: "int", nullable: false),
                    id_tipo = table.Column<int>(type: "int", nullable: false),
                    id_estado = table.Column<int>(type: "int", nullable: false),
                    id_cliente = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_equipo", x => x.id_equipo);
                    table.ForeignKey(
                        name: "FK_equipo_cliente",
                        column: x => x.id_cliente,
                        principalTable: "cliente",
                        principalColumn: "id_cliente");
                    table.ForeignKey(
                        name: "FK_equipo_estado",
                        column: x => x.id_estado,
                        principalTable: "estado_equipo",
                        principalColumn: "id_estado");
                    table.ForeignKey(
                        name: "FK_equipo_tipo",
                        column: x => x.id_tipo,
                        principalTable: "tipo_equipo",
                        principalColumn: "id_tipo");
                    table.ForeignKey(
                        name: "FK_esquipo_marca",
                        column: x => x.id_marca,
                        principalTable: "marca",
                        principalColumn: "id_marca");
                });

            migrationBuilder.CreateTable(
                name: "presupuesto",
                columns: table => new
                {
                    id_presupuesto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_tecnico = table.Column<int>(type: "int", nullable: false),
                    id_administrador = table.Column<int>(type: "int", nullable: false),
                    id_equipo = table.Column<int>(type: "int", nullable: false),
                    id_estado = table.Column<int>(type: "int", nullable: false, defaultValueSql: "('1')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_presupuesto", x => x.id_presupuesto);
                    table.ForeignKey(
                        name: "FK_presupuesto_administrador",
                        column: x => x.id_administrador,
                        principalTable: "usuario",
                        principalColumn: "id_usuario");
                    table.ForeignKey(
                        name: "FK_presupuesto_equipo",
                        column: x => x.id_equipo,
                        principalTable: "equipo",
                        principalColumn: "id_equipo");
                    table.ForeignKey(
                        name: "FK_presupuesto_estado",
                        column: x => x.id_estado,
                        principalTable: "estado_presupuesto",
                        principalColumn: "id_estado");
                    table.ForeignKey(
                        name: "FK_presupuesto_tecnico",
                        column: x => x.id_tecnico,
                        principalTable: "usuario",
                        principalColumn: "id_usuario");
                });

            migrationBuilder.CreateTable(
                name: "comentario",
                columns: table => new
                {
                    id_comentario = table.Column<int>(type: "int", nullable: false),
                    id_presupuesto = table.Column<int>(type: "int", nullable: false),
                    detalle = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    fecha = table.Column<DateOnly>(type: "date", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comentario", x => new { x.id_comentario, x.id_presupuesto });
                    table.ForeignKey(
                        name: "FK_comentario_presupuesto",
                        column: x => x.id_presupuesto,
                        principalTable: "presupuesto",
                        principalColumn: "id_presupuesto");
                });

            migrationBuilder.CreateTable(
                name: "orden_servicio",
                columns: table => new
                {
                    id_presupuesto = table.Column<int>(type: "int", nullable: false),
                    fecha = table.Column<DateOnly>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orden_servicio", x => x.id_presupuesto);
                    table.ForeignKey(
                        name: "FK__orden_ser__id_pr__05D8E0BE",
                        column: x => x.id_presupuesto,
                        principalTable: "presupuesto",
                        principalColumn: "id_presupuesto");
                });

            migrationBuilder.CreateTable(
                name: "item_presupuesto",
                columns: table => new
                {
                    n_fila = table.Column<int>(type: "int", nullable: false),
                    id_presupuesto = table.Column<int>(type: "int", nullable: false),
                    precio = table.Column<double>(type: "float", nullable: false),
                    id_orden = table.Column<int>(type: "int", nullable: true),
                    id_servicio = table.Column<int>(type: "int", nullable: false),
                    id_estado = table.Column<int>(type: "int", nullable: false),
                    necesario = table.Column<bool>(type: "bit", nullable: false, defaultValueSql: "('0')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item_presupuesto", x => new { x.n_fila, x.id_presupuesto });
                    table.ForeignKey(
                        name: "FK_item_estado",
                        column: x => x.id_estado,
                        principalTable: "estado_item",
                        principalColumn: "id_estado");
                    table.ForeignKey(
                        name: "FK_item_orden",
                        column: x => x.id_orden,
                        principalTable: "orden_servicio",
                        principalColumn: "id_presupuesto");
                    table.ForeignKey(
                        name: "FK_item_presupuesto_presupuesto",
                        column: x => x.id_presupuesto,
                        principalTable: "presupuesto",
                        principalColumn: "id_presupuesto");
                    table.ForeignKey(
                        name: "FK_item_servicio",
                        column: x => x.id_servicio,
                        principalTable: "servicio",
                        principalColumn: "id_servicio");
                });

            migrationBuilder.CreateIndex(
                name: "IX_comentario_id_presupuesto",
                table: "comentario",
                column: "id_presupuesto");

            migrationBuilder.CreateIndex(
                name: "IX_equipo_id_cliente",
                table: "equipo",
                column: "id_cliente");

            migrationBuilder.CreateIndex(
                name: "IX_equipo_id_estado",
                table: "equipo",
                column: "id_estado");

            migrationBuilder.CreateIndex(
                name: "IX_equipo_id_marca",
                table: "equipo",
                column: "id_marca");

            migrationBuilder.CreateIndex(
                name: "IX_equipo_id_tipo",
                table: "equipo",
                column: "id_tipo");

            migrationBuilder.CreateIndex(
                name: "IX_item_presupuesto_id_estado",
                table: "item_presupuesto",
                column: "id_estado");

            migrationBuilder.CreateIndex(
                name: "IX_item_presupuesto_id_orden",
                table: "item_presupuesto",
                column: "id_orden");

            migrationBuilder.CreateIndex(
                name: "IX_item_presupuesto_id_presupuesto",
                table: "item_presupuesto",
                column: "id_presupuesto");

            migrationBuilder.CreateIndex(
                name: "IX_item_presupuesto_id_servicio",
                table: "item_presupuesto",
                column: "id_servicio");

            migrationBuilder.CreateIndex(
                name: "IX_presupuesto_id_administrador",
                table: "presupuesto",
                column: "id_administrador");

            migrationBuilder.CreateIndex(
                name: "IX_presupuesto_id_equipo",
                table: "presupuesto",
                column: "id_equipo");

            migrationBuilder.CreateIndex(
                name: "IX_presupuesto_id_estado",
                table: "presupuesto",
                column: "id_estado");

            migrationBuilder.CreateIndex(
                name: "IX_presupuesto_id_tecnico",
                table: "presupuesto",
                column: "id_tecnico");

            migrationBuilder.CreateIndex(
                name: "IX_usuario_id_rol",
                table: "usuario",
                column: "id_rol");

            migrationBuilder.CreateIndex(
                name: "UQ_usuario_mail",
                table: "usuario",
                column: "mail",
                unique: true,
                filter: "[mail] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "comentario");

            migrationBuilder.DropTable(
                name: "item_presupuesto");

            migrationBuilder.DropTable(
                name: "estado_item");

            migrationBuilder.DropTable(
                name: "orden_servicio");

            migrationBuilder.DropTable(
                name: "servicio");

            migrationBuilder.DropTable(
                name: "presupuesto");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "equipo");

            migrationBuilder.DropTable(
                name: "estado_presupuesto");

            migrationBuilder.DropTable(
                name: "rol");

            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "estado_equipo");

            migrationBuilder.DropTable(
                name: "tipo_equipo");

            migrationBuilder.DropTable(
                name: "marca");
        }
    }
}
