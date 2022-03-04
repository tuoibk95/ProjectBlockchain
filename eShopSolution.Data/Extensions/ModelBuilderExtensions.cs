using eShopSolution.Data.Entities;
using eShopSolution.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "Home Tile", Value = "This is home page of eShopSolution" },
                new AppConfig() { Key = "Home Keyword", Value = "This is home page of eShopSolution" },
                new AppConfig() { Key = "Home Description", Value = "This is home page of eShopSolution" }
                );

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "jp-JP", Name = "Tiếng Nhật", IsDefault = false },
                new Language() { Id = "en-US", Name = "Tiếng Anh", IsDefault = false }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },
                new Category()
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 2,
                    Status = Status.Active
                });

            modelBuilder.Entity<CategoryTranslation>().HasData(
                        new CategoryTranslation()
                        {
                            Id = 1,
                            CategoryId = 1,
                            Name = "Áo nam",
                            LanguageId = "vi-VN",
                            SeoAlias = "ao-nam",
                            SeoDescription = "Sản phẩm thời trang nam",
                            SeoTitle = "thời trang nam"
                        },
                        new CategoryTranslation()
                        {
                            Id = 2,
                            CategoryId = 1,
                            Name = "Áo nữ",
                            LanguageId = "vi-VN",
                            SeoAlias = "ao-nu",
                            SeoDescription = "Sản phẩm thời trang nữ",
                            SeoTitle = "thời trang nữ"
                        },
                        new CategoryTranslation()
                        {
                            Id = 3,
                            CategoryId = 2,
                            Name = "men shirt",
                            LanguageId = "vi-VN",
                            SeoAlias = "ao-nam",
                            SeoDescription = "Sản phẩm thời trang nam",
                            SeoTitle = "thời trang nam"
                        },
                        new CategoryTranslation()
                        {
                            Id = 4,
                            CategoryId = 2,
                            Name = "women shirt",
                            LanguageId = "vi-VN",
                            SeoAlias = "ao-nu",
                            SeoDescription = "Sản phẩm thời trang nữ",
                            SeoTitle = "thời trang nữ"
                        }
                    );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 100000,
                    Price = 200000,
                    Stock = 0,
                    ViewCount = 0,
                });

            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation()
                {
                    Id = 1,
                    ProductId = 1,
                    Name = "Áo nam",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nam",
                    SeoDescription = "Sản phẩm thời trang nam",
                    SeoTitle = "thời trang nam",
                    Details = "Mô tả sản phẳm",
                    Description = ""
                },
                new ProductTranslation()
                {
                    Id = 2,
                    ProductId = 1,
                    Name = "Áo nữ",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nu",
                    SeoDescription = "Sản phẩm thời trang nữ",
                    SeoTitle = "thời trang nữ",
                    Details = "Mô tả sản phẳm",
                    Description = ""
                }
            );

            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory()
                {
                    ProductId = 1,
                    CategoryId = 1,
                });
        }
    }
}
