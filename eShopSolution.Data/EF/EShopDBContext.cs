using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.EF
{
    class EShopDBContext : DbContext
    {
        public EShopDBContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Product> Products { set; get; }
        public DbSet<Category> Categories { set; get; }
    }
}
