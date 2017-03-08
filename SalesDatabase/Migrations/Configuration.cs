namespace SalesDatabase.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SalesDatabase.SalesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "SalesDatabase.SalesContext";
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SalesDatabase.SalesContext context)
        {

            //06.Customers Migration
            context.Customers.AddOrUpdate(
              p => p.FirstName,
              new Customer { FirstName = "Andrew", LastName = "Peters" },
              new Customer { FirstName = "Brice", LastName = "Lambson" },
              new Customer { FirstName = "Rowan", LastName = "Miller" }
            );

        }
    }
}
