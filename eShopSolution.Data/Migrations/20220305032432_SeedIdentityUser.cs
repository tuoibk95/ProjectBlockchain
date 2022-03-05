using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("f23fe0b4-935b-4c6c-b589-657434a6a8c3"), "1ad6a93a-fef7-43ac-934b-93bea032e473", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("4d160af2-b902-4762-81fe-b22525645f4f"), 0, "30585aee-fca5-4e7f-93cb-5daba8865c67", new DateTime(1995, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "tuoith95@gmail.com", true, "Tuoi", "Le Van", false, null, "tuoith95@gmail.com", "admin", "AQAAAAEAACcQAAAAEGQR4iXgiSu5BFof+olrWijG61OriKGK2aJ6DM9n2wlFS4O5syDGaF+R5j5uI0VP/g==", null, false, "", false, "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("4d160af2-b902-4762-81fe-b22525645f4f"), new Guid("f23fe0b4-935b-4c6c-b589-657434a6a8c3") });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("f23fe0b4-935b-4c6c-b589-657434a6a8c3"));

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "Id",
                keyValue: new Guid("4d160af2-b902-4762-81fe-b22525645f4f"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("4d160af2-b902-4762-81fe-b22525645f4f"), new Guid("f23fe0b4-935b-4c6c-b589-657434a6a8c3") });

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
                value: new DateTime(2022, 3, 5, 9, 58, 29, 150, DateTimeKind.Local).AddTicks(6459));
        }
    }
}
