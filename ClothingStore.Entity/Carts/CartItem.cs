using ClothingStore.Entity.BaseEntities;
using ClothingStore.Entity.Products;
using ClothingStore.Entity.Users;
using ClothingStore.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClothingStore.Entity.Carts
{
	[Table("CartItem")]
	public class CartItem : BaseEntity
	{
		[Required]
		public int UserId { get; set; }

		[Required]
		public int ProductId { get; set; }

		[Required]
		public int Quantity { get; set; }

		public Size? Size { get; set; }

		[MaxLength(50)]
		public string? Color { get; set; }

		[ForeignKey("UserId")]
		public virtual User User { get; set; }

		[ForeignKey("ProductId")]
		public virtual Product Product { get; set; }
	}
}
