namespace SalesDatabase.Models
{
    using System.Collections;
    using System.Collections.Generic;
    public class Product
    {
        public Product()
        {
            SalesOfProduct = new HashSet<Sale>();
            
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public ICollection<Sale> SalesOfProduct { get; set; }
    }
}
