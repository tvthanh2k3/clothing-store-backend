using Microsoft.AspNetCore.Identity;

namespace ClothingStore.Entity.Roles
{
	public class Role : IdentityRole<int>
	{
		public string? Description { get; set; }

		// Bắt buộc
		public DateTime CreatedTime { get; set; }
		public string? CreatedBy { get; set; }
		public DateTime ModifiedTime { get; set; }
		public string? ModifiedBy { get; set; }

		// Sort delete
		public bool IsDeleted { get; set; }
	}
}
