using com.orthofeet.Entities.ofapi;
using Microsoft.EntityFrameworkCore;

namespace com.orthofeet.EntityFramework
{
	public class OfApiDbContext: DbContext
	{
		public DbSet<AppSetting> AppSettings { get; set; }

		public OfApiDbContext(DbContextOptions<OfApiDbContext> options)
			:base(options){}
	}
}