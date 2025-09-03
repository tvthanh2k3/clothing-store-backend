using ClothingStore.Entity.Roles;
using ClothingStore.Entity.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ClothingStore.Database.Contexts
{
	public class AppDbContext : IdentityDbContext<User, Role, int>
	{
		public AppDbContext() { }

		public AppDbContext(DbContextOptions options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			AppModuleBuilder.RegisterModule(builder);
		}
	}
}
