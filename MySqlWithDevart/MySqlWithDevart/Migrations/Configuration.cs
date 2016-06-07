namespace MySqlWithDevart.Migrations
{
	using Models;
	using System.Data.Entity.Migrations;
	using Devart.Data.MySql.Entity.Migrations;

	internal sealed class Configuration : DbMigrationsConfiguration<MariaContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;

			this.SetSqlGenerator(MySqlConnectionInfo.InvariantName, new MySqlEntityMigrationSqlGenerator());
		}

		protected override void Seed(MySqlWithDevart.Models.MariaContext context)
		{
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method
			//  to avoid creating duplicate seed data. E.g.
			//
			//    context.People.AddOrUpdate(
			//      p => p.FullName,
			//      new Person { FullName = "Andrew Peters" },
			//      new Person { FullName = "Brice Lambson" },
			//      new Person { FullName = "Rowan Miller" }
			//    );
			//
		}
	}
}