using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SalesDatabase.Models;

namespace SalesDatabase
{
    public class InitializeAndSeed : CreateDatabaseIfNotExists<SalesContext>
    {
        protected override void Seed(SalesContext context)
        {
            Product car = new Product();
            car.Name = "Car";
            car.Price = 2000m;
            car.Quantity = 10;

            Product truck = new Product();
            truck.Name = "Truck";
            truck.Price = 20000m;
            truck.Quantity = 8;

            Product bike = new Product();
            bike.Name = "Bike";
            bike.Price = 2060m;
            bike.Quantity = 5;
           
            Customer pesho = new Customer();
            pesho.FirstName = "Pesho";
            pesho.CreditCardNumber = "gfhdteuowxsl";

            Customer mitko = new Customer();
            mitko.FirstName = "Mitko";
            mitko.CreditCardNumber = "jfhiafujifuj";

            Customer georgi = new Customer();
            georgi.FirstName = "Georgi";
            georgi.CreditCardNumber = "hsaidaafjhifa";

            context.Customers.Add(georgi);
            context.Customers.Add(mitko);
            context.Customers.Add(pesho);

            StoreLocation loc = new StoreLocation();
            loc.LocationName = "Sofia";

            StoreLocation loc1 = new StoreLocation();
            loc1.LocationName = "Plovdiv";

            StoreLocation loc2 = new StoreLocation();
            loc2.LocationName = "Varna";

            Sale carSale = new Sale();
            carSale.Product = car;
            carSale.Customer = pesho;
            carSale.StoreLocation = loc;
            carSale.Date = DateTime.Now;

            Sale truckSale = new Sale();
            truckSale.Product = truck;
            truckSale.Customer = mitko;
            truckSale.StoreLocation = loc2;
            truckSale.Date = DateTime.Now;

            Sale bikeSale = new Sale();
            bikeSale.Product = bike;
            bikeSale.Customer = georgi;
            bikeSale.StoreLocation = loc1;
            bikeSale.Date = DateTime.Now;

            context.Sales.Add(bikeSale);
            context.Sales.Add(truckSale);
            context.Sales.Add(carSale);
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
