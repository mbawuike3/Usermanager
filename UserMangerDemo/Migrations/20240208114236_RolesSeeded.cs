using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UserMangerDemo.Migrations
{
    /// <inheritdoc />
    public partial class RolesSeeded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "194ef413-1415-4124-8b16-f78a3d9dbff9", "2", "User", "User" },
                    { "ce27ffb5-bc8c-45d9-986f-368d526d7da9", "1", "Admin", "Admin" },
                    { "fec76980-3008-45b6-8c43-f48d1948794c", "3", "HR", "HR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "194ef413-1415-4124-8b16-f78a3d9dbff9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce27ffb5-bc8c-45d9-986f-368d526d7da9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fec76980-3008-45b6-8c43-f48d1948794c");
        }
    }
}
