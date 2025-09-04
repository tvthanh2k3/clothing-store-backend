using ClothingStore.Entity.BaseEntities;
using ClothingStore.Entity.Users;
using ClothingStore.Shared;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClothingStore.Entity.Orders
{
	[Table("Order")]
	public class Order : BaseEntity
	{
		[Required]
		public int UserId { get; set; }

		[Required]
		[MaxLength(50)]
		public string? OrderNumber { get; set; }

		[Required]
		[Column(TypeName = "decimal(18,2)")]
		public decimal TotalAmount { get; set; }

		[Column(TypeName = "decimal(18,2)")]
		public decimal? DiscountAmount { get; set; }

		[Column(TypeName = "decimal(18,2)")]
		public decimal? ShippingFee { get; set; }

		[Required]
		public OrderStatus OrderStatus { get; set; } = OrderStatus.Pending;

		[Required]
		public PaymentStatus PaymentStatus { get; set; } = PaymentStatus.Unpaid;

		[Required]
		public PaymentMethod PaymentMethod { get; set; } = PaymentMethod.Cash;

		[MaxLength(1000)]
		public string? Notes { get; set; }

		// Ngày giao hàng
		public DateTime? ShippedDate { get; set; }

		// Ngày nhận hàng
		public DateTime? DeliveredDate { get; set; }

		[ForeignKey("UserId")]
		public virtual User User { get; set; }

		public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
	}
}
