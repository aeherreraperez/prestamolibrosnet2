using Microsoft.EntityFrameworkCore.Migrations;

namespace prestamolibrosnet.Data.Migrations
{
    public partial class estado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "estado",
                table: "Libro",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "estado",
                table: "Libro");
        }
    }
}
