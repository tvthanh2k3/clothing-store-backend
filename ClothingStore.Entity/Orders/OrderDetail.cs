using ClothingStore.Entity.BaseEntities;
using ClothingStore.Entity.Products;
using ClothingStore.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClothingStore.Entity.Orders
{
	[Table("OrderDetail")]
	public class OrderDetail : BaseEntity
	{
		[Required]
		public int OrderId { get; set; }

		[Required]
		public int ProductId { get; set; }

		[Required]
		public int Quantity { get; set; }

		[Required]
		[Column(TypeName = "decimal(18,2)")]
		public decimal UnitPrice { get; set; }

		[Column(TypeName = "decimal(18,2)")]
		public decimal? DiscountPrice { get; set; }

		public Size? Size { get; set; }

		[MaxLength(50)]
		public string? Color { get; set; }

		[ForeignKey("OrderId")]
		public virtual Order Order { get; set; }

		[ForeignKey("ProductId")]
		public virtual Product Product { get; set; }
	}
}
