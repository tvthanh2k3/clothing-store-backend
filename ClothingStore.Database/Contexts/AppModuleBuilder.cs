using ClothingStore.Entity.Roles;
using ClothingStore.Entity.Users;
using Microsoft.EntityFrameworkCore;

namespace ClothingStore.Database.Contexts
{
	public class AppModuleBuilder
	{
		public static void RegisterModule(ModelBuilder builder)
		{
			// Custom User
			builder.Entity<User>()
				.HasIndex(u => u.NormalizedUserName)
				.HasDatabaseName("UserNameIndex")
				.IsUnique(false); // Loại bỏ Unique Constraint

			// Custom Role
			builder.Entity<Role>()
				.HasIndex(r => r.NormalizedName)
				.HasDatabaseName("RoleNameIndex")
				.IsUnique(false); // Loại bỏ Unique Constraint
		}
	}
}
