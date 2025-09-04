using ClothingStore.Entity.BaseEntities;
using ClothingStore.Entity.Products;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClothingStore.Entity.Categories
{
	[Table("Category")]
	public class Category : BaseEntity
	{
		[Required]
		[MaxLength(100)]
		public string CategoryName { get; set; }

		[MaxLength(500)]
		public string? Description { get; set; }

		[MaxLength(200)]
		public string? ImageUrl { get; set; }

		public bool IsActive { get; set; } = true;

		public virtual ICollection<Product> Products { get; set; } = new List<Product>();
	}
}
