using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class AddingProducts2Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19bd17d1-7312-421d-a53c-2081308ff673");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4c4c8faf-6263-46a8-a237-c71c93e89a2b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4610a4de-b390-45e4-8f7b-6597b588605a", "7fa3f960-1653-44ed-b66d-6be713f4e650", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cb91bbde-3839-49d1-92fe-6a4a3add908f", "9904ca23-add4-4914-8838-77c48c69a323", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4610a4de-b390-45e4-8f7b-6597b588605a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb91bbde-3839-49d1-92fe-6a4a3add908f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "19bd17d1-7312-421d-a53c-2081308ff673", "b74456cb-999a-40ca-be7d-437a2b570a25", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4c4c8faf-6263-46a8-a237-c71c93e89a2b", "3e85a792-659a-4a00-a1f8-01eff45152d9", "Admin", "ADMIN" });
        }
    }
}
