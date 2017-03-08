namespace _01_02.Local_Store
{
    public class Product
    {
        public Product()
        {
        }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string DistributorName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        //2. Local Store Improvement (ctrl+k+c for p.01)
        public double Weight { get; set; }
        public double Quantity { get; set; }
    }
}
