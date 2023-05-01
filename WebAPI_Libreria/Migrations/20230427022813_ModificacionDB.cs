using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI_Libreria.Migrations
{
    public partial class ModificacionDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "Autores",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "Autores");
        }
    }
}
