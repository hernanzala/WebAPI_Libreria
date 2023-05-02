﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI_Libreria.Migrations
{
    public partial class AgregarTienda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tienda",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Denominacion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tienda", x => x.Codigo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tienda");
        }
    }
}
