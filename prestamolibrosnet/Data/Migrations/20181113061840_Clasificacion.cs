using Microsoft.EntityFrameworkCore.Migrations;

namespace prestamolibrosnet.Data.Migrations
{
    public partial class Clasificacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerID",
                table: "Calificacion",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Calificacion");
        }
    }
}
