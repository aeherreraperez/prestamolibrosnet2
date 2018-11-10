using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace prestamolibrosnet.Data.Migrations
{
    public partial class prestamo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    email = table.Column<string>(nullable: true),
                    nombre = table.Column<string>(nullable: true),
                    apellido = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    direccion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Libro",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isbn = table.Column<string>(nullable: true),
                    titulo = table.Column<string>(nullable: true),
                    autor = table.Column<string>(nullable: true),
                    fecha = table.Column<int>(nullable: false),
                    editorial = table.Column<string>(nullable: true),
                    categoriaid = table.Column<int>(nullable: true),
                    OwnerID = table.Column<string>(nullable: true),
                    prestado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libro", x => x.id);
                    table.ForeignKey(
                        name: "FK_Libro_Categoria_categoriaid",
                        column: x => x.categoriaid,
                        principalTable: "Categoria",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Prestamo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    libroid = table.Column<int>(nullable: true),
                    OwnerID = table.Column<string>(nullable: true),
                    fechaRealizado = table.Column<DateTime>(nullable: false),
                    fechaDevolucion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamo", x => x.id);
                    table.ForeignKey(
                        name: "FK_Prestamo_Libro_libroid",
                        column: x => x.libroid,
                        principalTable: "Libro",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Calificacion",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    usuarioid = table.Column<int>(nullable: true),
                    prestamoid = table.Column<int>(nullable: true),
                    evaluacion = table.Column<int>(nullable: false),
                    observacion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calificacion", x => x.id);
                    table.ForeignKey(
                        name: "FK_Calificacion_Prestamo_prestamoid",
                        column: x => x.prestamoid,
                        principalTable: "Prestamo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Calificacion_Usuario_usuarioid",
                        column: x => x.usuarioid,
                        principalTable: "Usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calificacion_prestamoid",
                table: "Calificacion",
                column: "prestamoid");

            migrationBuilder.CreateIndex(
                name: "IX_Calificacion_usuarioid",
                table: "Calificacion",
                column: "usuarioid");

            migrationBuilder.CreateIndex(
                name: "IX_Libro_categoriaid",
                table: "Libro",
                column: "categoriaid");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_libroid",
                table: "Prestamo",
                column: "libroid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calificacion");

            migrationBuilder.DropTable(
                name: "Prestamo");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Libro");

            migrationBuilder.DropTable(
                name: "Categoria");
        }
    }
}
