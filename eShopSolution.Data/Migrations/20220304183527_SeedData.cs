using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "Home Tile", "This is home page of eShopSolution" },
                    { "Home Keyword", "This is home page of eShopSolution" },
                    { "Home Description", "This is home page of eShopSolution" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsShowOnHome", "ParentId", "SortOrder", "Status" },
                values: new object[,]
                {
                    { 1, true, null, 1, 1 },
                    { 2, true, null, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "IsDefault", "Name" },
                values: new object[,]
                {
                    { "vi-VN", true, "Tiếng Việt" },
                    { "jp-JP", false, "Tiếng Nhật" },
                    { "en-US", false, "Tiếng Anh" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateCreated", "IsFeatured", "OriginalPrice", "Price", "SeoAlias" },
                values: new object[] { 1, new DateTime(2022, 3, 5, 1, 35, 27, 280, DateTimeKind.Local).AddTicks(1023), null, 100000m, 200000m, null });

            migrationBuilder.InsertData(
                table: "CategoryTranslations",
                columns: new[] { "Id", "CategoryId", "ContactId", "LanguageId", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, 1, null, "vi-VN", "Áo nam", "ao-nam", "Sản phẩm thời trang nam", "thời trang nam" },
                    { 2, 1, null, "vi-VN", "Áo nữ", "ao-nu", "Sản phẩm thời trang nữ", "thời trang nữ" },
                    { 3, 2, null, "vi-VN", "men shirt", "ao-nam", "Sản phẩm thời trang nam", "thời trang nam" },
                    { 4, 2, null, "vi-VN", "women shirt", "ao-nu", "Sản phẩm thời trang nữ", "thời trang nữ" }
                });

            migrationBuilder.InsertData(
                table: "ProductInCategories",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "ProductTranslations",
                columns: new[] { "Id", "ContactId", "Description", "Details", "LanguageId", "Name", "ProductId", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[,]
                {
                    { 1, null, "", "Mô tả sản phẳm", "vi-VN", "Áo nam", 1, "ao-nam", "Sản phẩm thời trang nam", "thời trang nam" },
                    { 2, null, "", "Mô tả sản phẳm", "vi-VN", "Áo nữ", 1, "ao-nu", "Sản phẩm thời trang nữ", "thời trang nữ" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "Home Description");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "Home Keyword");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "Home Tile");

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "en-US");

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "jp-JP");

            migrationBuilder.DeleteData(
                table: "ProductInCategories",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "vi-VN");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
