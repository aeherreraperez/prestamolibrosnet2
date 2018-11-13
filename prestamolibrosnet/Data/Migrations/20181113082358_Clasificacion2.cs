using Microsoft.EntityFrameworkCore.Migrations;

namespace prestamolibrosnet.Data.Migrations
{
    public partial class Clasificacion2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idPrestamo",
                table: "Calificacion",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idPrestamo",
                table: "Calificacion");
        }
    }
}
