namespace SalesDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.Entity;
    using SalesDatabase.Models;
    

    public class SalesContext : DbContext
    {
       
        public SalesContext()
            : base("name=SalesContext")
        {
            
            
            //03.SalesDatabase
            //Database.SetInitializer(
            //     new InitializeAndSeed());
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<StoreLocation> StoreLocations { get; set; }

    }

}