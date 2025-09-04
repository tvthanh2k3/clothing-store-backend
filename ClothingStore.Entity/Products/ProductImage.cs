using ClothingStore.Entity.BaseEntities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClothingStore.Entity.Products
{
	[Table("ProductImage")]
	public class ProductImage : BaseEntity
	{
		[Required]
		public int ProductId { get; set; }

		[Required]
		[MaxLength(500)]
		public string ImageUrl { get; set; }

		public bool IsMainImage { get; set; } = false;
		public int DisplayOrder { get; set; } = 0;

		[ForeignKey("ProductId")]
		public virtual Product Product { get; set; }
	}
}
