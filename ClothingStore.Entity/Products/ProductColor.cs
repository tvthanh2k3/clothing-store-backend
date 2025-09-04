using ClothingStore.Entity.BaseEntities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClothingStore.Entity.Products
{
	[Table("ProductColor")]
	public class ProductColor : BaseEntity
	{
		[Required]
		public int ProductId { get; set; }

		[Required]
		[MaxLength(50)]
		public string ColorName { get; set; }

		[MaxLength(7)]
		public string? ColorCode { get; set; } // Hex color code

		[Required]
		public int Quantity { get; set; }

		public bool IsActive { get; set; } = true;

		[ForeignKey("ProductId")]
		public virtual Product Product { get; set; }
	}
}
