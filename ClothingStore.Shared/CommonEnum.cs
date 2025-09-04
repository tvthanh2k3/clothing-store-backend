using System.ComponentModel.DataAnnotations;

namespace ClothingStore.Shared
{
	public enum OrderStatus
	{
		[Display(Name = "Chưa xác nhận")]
		Pending = 1,
		[Display(Name = "Đã Xác nhận")]
		Confirmed = 2,
		[Display(Name = "Đang xử lý")]
		Processing = 3,
		[Display(Name = "Đã vận chuyển")]
		Shipped = 4,
		[Display(Name = "Đã giao hàng")]
		Delivered = 5,
		[Display(Name = "Đã hủy")]
		Cancelled = 6
	}

	public enum PaymentStatus
	{
		[Display(Name = "Chưa thanh toán")]
		Unpaid = 1,
		[Display(Name = "Đã thanh toán")]
		Paid = 2,
		[Display(Name = "Đã hoàn tiền")]
		Refunded = 3,
	}

	public enum PaymentMethod
	{
		[Display(Name = "Thanh toán khi nhận hàng")]
		Cash = 1,
		[Display(Name = "Chuyển khoản")]
		Transfer = 2
	}

	public enum Gender
	{
		[Display(Name = "Nam")]
		Male = 1,
		[Display(Name = "Nữ")]
		Female = 2,
		[Display(Name = "Unisex")]
		Unisex = 3,
	}

	public enum Size
	{
		[Display(Name = "XS")]
		XS = 1,
		[Display(Name = "S")]
		S = 2,
		[Display(Name = "M")]
		M = 3,
		[Display(Name = "L")]
		L = 4,
		[Display(Name = "XL")]
		XL = 5,
		[Display(Name = "XXL")]
		XXL = 6
	}
}
