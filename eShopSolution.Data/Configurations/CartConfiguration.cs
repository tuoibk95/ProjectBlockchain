using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Repositories
{
	public class CartConfiguration : IEmtityTypeConfiguration<Cart>
	{
		public void Configuration(EntityTypeBuilder<Cart> builder)
		{
			builder.ToTable("Carts");
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).UseIdentityColumn();
			builder.HasOne(x => x.Product).WithMany(x => Carts).HasForeignKey(x => x.ProductId);
			builder.HasOne(x => x.AppUser).WithMany(x => Carts).HasForeignKey(x => x.UserId);
		}
	}
}