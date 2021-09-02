using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "dd129ca6-789f-4d7c-9879-09138d7a74dd", "8f97fdc7-589b-4aef-ba3d-294a2eb5741d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ae6153bf-43e2-47af-a95a-98ddc6fee1d3", "9fe0f324-740e-42a7-9355-5b75283f6cd7", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae6153bf-43e2-47af-a95a-98ddc6fee1d3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd129ca6-789f-4d7c-9879-09138d7a74dd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4610a4de-b390-45e4-8f7b-6597b588605a", "7fa3f960-1653-44ed-b66d-6be713f4e650", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "cb91bbde-3839-49d1-92fe-6a4a3add908f", "9904ca23-add4-4914-8838-77c48c69a323", "Admin", "ADMIN" });
        }
    }
}
