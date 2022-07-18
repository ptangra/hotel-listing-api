using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hotel_listing_api.Migrations
{
    public partial class addedDefaulltRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "46d676b7-840b-435a-8cc2-6cc0bf434e75", "da802595-2334-46c6-a008-144162ebc147", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "712f275d-5884-40de-b72c-a3c622e02ba9", "ff8bc465-30a8-4f82-a126-b26c2125fc81", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46d676b7-840b-435a-8cc2-6cc0bf434e75");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "712f275d-5884-40de-b72c-a3c622e02ba9");
        }
    }
}
