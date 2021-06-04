using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { "ASH", "Aseo Hogar" },
                    { "PRF", "Perfumeria" },
                    { "ASP", "Aseo Personal" },
                    { "HGR", "Hogar" },
                    { "SLD", "SALUD" }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[,]
                {
                    { "92233a8e-a311-47f9-95f5-b74abed0ba27", "Quito", "BodegaCentral" },
                    { "cff01449-e8c2-4ac4-b904-d227060e3344", "GYE", "Bodega Lateral" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "ASH");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "ASP");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "HGR");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "PRF");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: "SLD");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "92233a8e-a311-47f9-95f5-b74abed0ba27");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "cff01449-e8c2-4ac4-b904-d227060e3344");
        }
    }
}
