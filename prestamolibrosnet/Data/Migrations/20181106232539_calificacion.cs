using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace prestamolibrosnet.Data.Migrations
{
    public partial class calificacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clasificacion");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calificacion");

            migrationBuilder.CreateTable(
                name: "Clasificacion",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    evaluacion = table.Column<int>(nullable: false),
                    observacion = table.Column<string>(nullable: true),
                    prestamoid = table.Column<int>(nullable: true),
                    usuarioid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clasificacion", x => x.id);
                    table.ForeignKey(
                        name: "FK_Clasificacion_Prestamo_prestamoid",
                        column: x => x.prestamoid,
                        principalTable: "Prestamo",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clasificacion_Usuario_usuarioid",
                        column: x => x.usuarioid,
                        principalTable: "Usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clasificacion_prestamoid",
                table: "Clasificacion",
                column: "prestamoid");

            migrationBuilder.CreateIndex(
                name: "IX_Clasificacion_usuarioid",
                table: "Clasificacion",
                column: "usuarioid");
        }
    }
}
