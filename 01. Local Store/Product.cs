namespace _01.Local_Store
{
    public class Product
    {
        public Product(string name, string distributorName, string description, decimal price)
        {
            this.Name = name;
            this.DistributorName = distributorName;
            this.Description = description;
            this.Price = price;
        }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string DistributorName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
