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
                    { "ASP", "Aseo Personal" },
                    { "HGR", "Hogar" }
                });

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "WareHouseId", "WareHouseAddress", "WareHouseName" },
                values: new object[,]
                {
                    { "55604e2a-e472-4b7a-b4b9-5c0626562829", "San Miguel", "Bodega Central" },
                    { "13e27349-925a-4e8d-ab03-e136a7a9d7c0", "San Luis", "Bodega Auxiliar" }
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
                table: "WareHouses",
                keyColumn: "WareHouseId",
                keyValue: "13e27349-925a-4e8d-ab03-e136a7a9d7c0");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WareHouseId",
                keyValue: "55604e2a-e472-4b7a-b4b9-5c0626562829");
        }
    }
}
