namespace MySqlWithDevart.Models
{
	using System.Data.Entity;

	public partial class MariaContext : DbContext
	{
		public MariaContext()
			: base("name=MariaContext")
		{
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
		}
	}
}