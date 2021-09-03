using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class initialmigrationtjm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8f2a4225-8a2f-4cbf-afab-4eb58be12ac9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b9167d1-ff30-41ef-b58d-a80dc046e86c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "99b44f4b-f389-4da2-9115-bf1929f76e5d", "68cba88b-b42c-4948-a62b-fbd6f46dfd9e", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e4c62a9f-d3b9-4580-a630-87e1641b5707", "49ca7a9a-07cd-44ec-8305-6ae7ddda0635", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99b44f4b-f389-4da2-9115-bf1929f76e5d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4c62a9f-d3b9-4580-a630-87e1641b5707");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8f2a4225-8a2f-4cbf-afab-4eb58be12ac9", "ad364f90-b7cd-4511-b7c2-4dd437a42ef5", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9b9167d1-ff30-41ef-b58d-a80dc046e86c", "4373e3c9-5c12-4b50-a608-61a10c64e7d1", "Admin", "ADMIN" });
        }
    }
}
