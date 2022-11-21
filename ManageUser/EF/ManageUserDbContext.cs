using Microsoft.EntityFrameworkCore;
using MvcMovie.Entities;

namespace ManageUser.EF
{
	public class ManageUserDbContext : DbContext
	{
		public ManageUserDbContext() { }

		public DbSet<TblUser> TblUsers { get; set; }
		public DbSet<MstGroup> MstGroups { get; set; }
		public DbSet<MstJapan> MstJapans { get; set; }
		public DbSet<TblDetailUserJapan> TblDetailUserJapans { get; set; }
	}
}
