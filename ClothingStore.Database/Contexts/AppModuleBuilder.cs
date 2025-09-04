using ClothingStore.Entity.Carts;
using ClothingStore.Entity.Categories;
using ClothingStore.Entity.Orders;
using ClothingStore.Entity.Products;
using ClothingStore.Entity.Roles;
using ClothingStore.Entity.Users;
using Microsoft.EntityFrameworkCore;

namespace ClothingStore.Database.Contexts
{
	public class AppModuleBuilder
	{
		public static void RegisterModule(ModelBuilder builder)
		{
			builder.Entity<Product>()
				.HasOne(p => p.Category)
				.WithMany(c => c.Products)
				.HasForeignKey(p => p.CategoryId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<ProductImage>()
				.HasOne(pi => pi.Product)
				.WithMany(p => p.ProductImages)
				.HasForeignKey(pi => pi.ProductId)
				.OnDelete(DeleteBehavior.Cascade);

			builder.Entity<ProductSize>()
				.HasOne(ps => ps.Product)
				.WithMany(p => p.ProductSizes)
				.HasForeignKey(ps => ps.ProductId)
				.OnDelete(DeleteBehavior.Cascade);

			builder.Entity<ProductColor>()
				.HasOne(pc => pc.Product)
				.WithMany(p => p.ProductColors)
				.HasForeignKey(pc => pc.ProductId)
				.OnDelete(DeleteBehavior.Cascade);

			builder.Entity<Order>()
				.HasOne(o => o.User)
				.WithMany(u => u.Orders)
				.HasForeignKey(o => o.UserId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<OrderDetail>()
				.HasOne(od => od.Order)
				.WithMany(o => o.OrderDetails)
				.HasForeignKey(od => od.OrderId)
				.OnDelete(DeleteBehavior.Cascade);

			builder.Entity<OrderDetail>()
				.HasOne(od => od.Product)
				.WithMany(p => p.OrderDetails)
				.HasForeignKey(od => od.ProductId)
				.OnDelete(DeleteBehavior.Restrict);

			builder.Entity<CartItem>()
				.HasOne(ci => ci.User)
				.WithMany(u => u.CartItems)
				.HasForeignKey(ci => ci.UserId)
				.OnDelete(DeleteBehavior.Cascade);

			builder.Entity<CartItem>()
				.HasOne(ci => ci.Product)
				.WithMany(p => p.CartItems)
				.HasForeignKey(ci => ci.ProductId)
				.OnDelete(DeleteBehavior.Cascade);

			builder.Entity<Category>()
				.HasIndex(c => c.CategoryName)
				.IsUnique();

			builder.Entity<Order>()
				.HasIndex(o => o.OrderNumber)
				.IsUnique();

			builder.Entity<ProductSize>()
				.HasIndex(ps => new { ps.ProductId, ps.Size })
				.IsUnique();

			builder.Entity<ProductColor>()
				.HasIndex(pc => new { pc.ProductId, pc.ColorName })
				.IsUnique();

			builder.Entity<CartItem>()
				.HasIndex(ci => new { ci.UserId, ci.ProductId, ci.Size, ci.Color })
				.IsUnique();

			builder.Entity<Product>()
				.Property(p => p.Price)
				.HasPrecision(18, 2);

			builder.Entity<Product>()
				.Property(p => p.DiscountPrice)
				.HasPrecision(18, 2);

			builder.Entity<Order>()
				.Property(o => o.TotalAmount)
				.HasPrecision(18, 2);

			builder.Entity<Order>()
				.Property(o => o.DiscountAmount)
				.HasPrecision(18, 2);

			builder.Entity<Order>()
				.Property(o => o.ShippingFee)
				.HasPrecision(18, 2);

			builder.Entity<OrderDetail>()
				.Property(od => od.UnitPrice)
				.HasPrecision(18, 2);

			builder.Entity<OrderDetail>()
				.Property(od => od.DiscountPrice)
				.HasPrecision(18, 2);

			builder.Entity<Order>()
				.Property(o => o.OrderStatus)
				.HasConversion<int>();

			builder.Entity<Order>()
				.Property(o => o.PaymentStatus)
				.HasConversion<int>();

			builder.Entity<Order>()
				.Property(o => o.PaymentMethod)
				.HasConversion<int>();

			builder.Entity<Product>()
				.Property(p => p.Gender)
				.HasConversion<int?>();

			builder.Entity<ProductSize>()
				.Property(ps => ps.Size)
				.HasConversion<int>();

			builder.Entity<OrderDetail>()
				.Property(od => od.Size)
				.HasConversion<int?>();

			builder.Entity<CartItem>()
				.Property(ci => ci.Size)
				.HasConversion<int?>();

			builder.Entity<Category>().HasQueryFilter(e => !e.IsDeleted);
			builder.Entity<Product>().HasQueryFilter(e => !e.IsDeleted);
			builder.Entity<ProductImage>().HasQueryFilter(e => !e.IsDeleted);
			builder.Entity<ProductSize>().HasQueryFilter(e => !e.IsDeleted);
			builder.Entity<ProductColor>().HasQueryFilter(e => !e.IsDeleted);
			builder.Entity<Order>().HasQueryFilter(e => !e.IsDeleted);
			builder.Entity<OrderDetail>().HasQueryFilter(e => !e.IsDeleted);
			builder.Entity<CartItem>().HasQueryFilter(e => !e.IsDeleted);
			builder.Entity<User>().HasQueryFilter(e => !e.IsDeleted);
			builder.Entity<Role>().HasQueryFilter(e => !e.IsDeleted);

			builder.Entity<User>().ToTable("User");
			builder.Entity<Role>().ToTable("Role");
			builder.Entity<Category>().ToTable("Category");
			builder.Entity<Product>().ToTable("Product");
			builder.Entity<ProductImage>().ToTable("ProductImage");
			builder.Entity<ProductSize>().ToTable("ProductSize");
			builder.Entity<ProductColor>().ToTable("ProductColor");
			builder.Entity<Order>().ToTable("Order");
			builder.Entity<OrderDetail>().ToTable("OrderDetail");
			builder.Entity<CartItem>().ToTable("CartItem");
		}
	}
}
