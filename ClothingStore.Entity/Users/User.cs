using ClothingStore.Entity.Carts;
using ClothingStore.Entity.Orders;
using Microsoft.AspNetCore.Identity;

namespace ClothingStore.Entity.Users
{
	public class User : IdentityUser<int>
	{
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? AvatarURL { get; set; }

		// Bắt buộc
		public DateTime CreatedTime { get; set; }
		public string? CreatedBy { get; set; }
		public DateTime ModifiedTime { get; set; }
		public string? ModifiedBy { get; set; }

		// Sort delete
		public bool IsDeleted { get; set; }

		public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
		public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
	}
}
