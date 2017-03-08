using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Local_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Product milk = new Product("Prqsno mlqko", "Danon", "Krave mlqko", 2.00M);
            Product cheese = new Product("Bqlo sirene", "Sirene i vino", " Sirene ot svobodni kravi", 15);
            Product yellowCheese = new Product("Kashkaval", "Sirene i vino", "Kashkavalche", 25);

            var context = new ProductsContext();
            context.Products.Add(milk);
            context.Products.Add(cheese);
            context.Products.Add(yellowCheese);

            context.SaveChanges();
        }
    }
}
