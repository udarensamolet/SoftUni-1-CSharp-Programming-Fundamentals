namespace ShoppingSpree
{
    class Product
    {
        public Product(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name { get; set; }
        public double Cost { get; set; }
    }
}
