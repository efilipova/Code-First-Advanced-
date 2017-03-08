using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02.Local_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Local Store Improvement (before that delete DB from problem 01 and backup data)
            //Build DB again (with 2 new Product properties)
            var context = new ProductsContext();
            context.Database.Initialize(true);
            //Insert backedup data from p.01


            //01.Local Store

            //Product milk = new Product();
            //milk.Description = "Krave mlqko";
            //milk.Name = "Prqsno mlqko";
            //milk.DistributorName = "Danon";
            //milk.Price = 2.00m;

            //Product cheese = new Product();
            //cheese.Name = "Bqlo sirene";
            //cheese.DistributorName = "Sirene i vino";
            //cheese.Description = "Sirene ot svobodni kravi";
            //cheese.Price = 15.00m;

            //Product yellowCheese = new Product();
            //yellowCheese.Name = "Kaskaval";
            //yellowCheese.DistributorName = "Sirene i vino";
            //yellowCheese.Description = "Kashkavalche";
            //yellowCheese.Price = 25;

            //context.Products.Add(milk);
            //context.Products.Add(cheese);
            //context.Products.Add(yellowCheese);
            //context.SaveChanges();
        }
    }
}
