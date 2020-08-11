using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiModulo10.Migrations
{
    public partial class nuevoautor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Autores",
                columns: new[] { "Id", "FechaNacimiento", "Identificacion", "Nombre" },
                values: new object[] { 3, new DateTime(1985, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Alejandro Lopera" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Autores",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
