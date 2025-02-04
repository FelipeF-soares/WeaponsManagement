using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WeaponsManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class TableValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Id", "City", "Name", "Neighborhood", "Number", "State", "Street", "UnitCode", "ZIPCode" },
                values: new object[] { 1, "São Sebastião", "Batalhão", "Paulista", "1", "São Paulo", "Av. Brasil", "100", "0800-000" });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "Id", "Description", "Factory", "MaterialCode", "PatrimonyNumber", "SerialNumber", "UnitId", "Value" },
                values: new object[,]
                {
                    { 1, ".40", "Taurus", "1000", "1234", "AXS9878", 1, "169,69" },
                    { 2, ".40", "Glock", "1000", "4321", "AXS9978", 1, "369,69" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
