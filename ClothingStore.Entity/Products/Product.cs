using ClothingStore.Entity.BaseEntities;
using ClothingStore.Entity.Carts;
using ClothingStore.Entity.Categories;
using ClothingStore.Entity.Orders;
using ClothingStore.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClothingStore.Entity.Products
{
	[Table("Product")]
	public class Product : BaseEntity
	{
		[Required]
		[MaxLength(200)]
		public string ProductName { get; set; }

		[MaxLength(1000)]
		public string? Description { get; set; }

		[Required]
		[Column(TypeName = "decimal(18,2)")]
		public decimal Price { get; set; }

		[Column(TypeName = "decimal(18,2)")]
		public decimal? DiscountPrice { get; set; }

		[Required]
		public int StockQuantity { get; set; }

		[MaxLength(50)]
		public string? Brand { get; set; }

		public Gender? Gender { get; set; }

		public bool IsActive { get; set; } = true;

		[Required]
		public int CategoryId { get; set; }

		[ForeignKey("CategoryId")]
		public virtual Category Category { get; set; }

		public virtual ICollection<ProductImage> ProductImages { get; set; } = new List<ProductImage>();
		public virtual ICollection<ProductSize> ProductSizes { get; set; } = new List<ProductSize>();
		public virtual ICollection<ProductColor> ProductColors { get; set; } = new List<ProductColor>();
		public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
		public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
	}
}
