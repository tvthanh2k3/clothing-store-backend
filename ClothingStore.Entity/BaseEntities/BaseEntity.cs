namespace ClothingStore.Entity.BaseEntities
{
	public class BaseEntity
	{
		public int Id { get; set; }

		// Bắt buộc
		public DateTime CreatedTime { get; set; }
		public string? CreatedBy { get; set; }
		public DateTime ModifiedTime { get; set; }
		public string? ModifiedBy { get; set; }

		// Sort delete
		public bool IsDeleted { get; set; }
	}
}
