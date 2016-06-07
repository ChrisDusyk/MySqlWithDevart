namespace MySqlWithDevart.Models
{
	using System.Data.Entity;

	public partial class MariaContext : DbContext
	{
		public MariaContext()
			: base("name=MariaContext")
		{
			
		}

		public virtual DbSet<Customer> Customers { get; set; }
		
		public virtual DbSet<Order> Orders { get; set; }

		public virtual DbSet<Product> Products { get; set; }

		public virtual DbSet<OrderProduct> OrderProducts { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
		}
	}
}