using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eshopSolution.Data.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
	{
		public void Configure(EntityTypeBuilder<AppUser> builder)
		{
			builder.ToTable("AppUser");
			builder.Property(x => x.FirstName).IsRequired().HasMaxLength(200);
			builder.Property(x => x.LastName).IsRequired().HasMaxLength(200);
			builder.Property(x => x.Dob).IsRequired();
		}
	}
}