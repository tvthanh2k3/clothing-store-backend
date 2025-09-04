using ClothingStore.Entity.BaseEntities;
using ClothingStore.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClothingStore.Entity.Products
{
	[Table("ProductSize")]
	public class ProductSize : BaseEntity
	{
		[Required]
		public int ProductId { get; set; }

		[Required]
		public Size Size { get; set; }

		[Required]
		public int Quantity { get; set; }

		public bool IsActive { get; set; } = true;

		[ForeignKey("ProductId")]
		public virtual Product Product { get; set; }
	}
}
