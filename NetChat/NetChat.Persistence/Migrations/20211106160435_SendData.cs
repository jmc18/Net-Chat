using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetChat.Persistence.Migrations
{
    public partial class SendData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("8deb6cd6-71f8-4871-a56c-a666c93ad6bb"), "Dedicated channel to NetCore", "DotNetCore" });

            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("ba6a0cb2-34d3-42fa-beb2-b38acd8e22b6"), "Dedicated channel to ReacJS", "Reac JS" });

            migrationBuilder.InsertData(
                table: "Channels",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("dc924665-25e4-42bb-8144-14976986e74b"), "Dedicated channel to Angular", "Angular" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "Id",
                keyValue: new Guid("8deb6cd6-71f8-4871-a56c-a666c93ad6bb"));

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "Id",
                keyValue: new Guid("ba6a0cb2-34d3-42fa-beb2-b38acd8e22b6"));

            migrationBuilder.DeleteData(
                table: "Channels",
                keyColumn: "Id",
                keyValue: new Guid("dc924665-25e4-42bb-8144-14976986e74b"));
        }
    }
}
