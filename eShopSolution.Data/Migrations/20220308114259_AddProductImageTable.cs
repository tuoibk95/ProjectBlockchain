using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f23fe0b4-935b-4c6c-b589-657434a6a8c3"),
                column: "ConcurrencyStamp",
                value: "66fc7e27-3cc1-4c1c-84bd-6f81e5f41848");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("4d160af2-b902-4762-81fe-b22525645f4f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8a26b305-3099-40c5-baf6-33290618efc8", "AQAAAAEAACcQAAAAEGu6Y2fz2oKcMox3KT3sMGpDWVGBilL9JGj4Qc/u3vajMq5HRWgaI8CXdhh1rfQRng==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 8, 18, 42, 58, 851, DateTimeKind.Local).AddTicks(8153));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f23fe0b4-935b-4c6c-b589-657434a6a8c3"),
                column: "ConcurrencyStamp",
                value: "1ad6a93a-fef7-43ac-934b-93bea032e473");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("4d160af2-b902-4762-81fe-b22525645f4f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "30585aee-fca5-4e7f-93cb-5daba8865c67", "AQAAAAEAACcQAAAAEGQR4iXgiSu5BFof+olrWijG61OriKGK2aJ6DM9n2wlFS4O5syDGaF+R5j5uI0VP/g==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 3, 5, 10, 24, 32, 138, DateTimeKind.Local).AddTicks(2085));
        }
    }
}
