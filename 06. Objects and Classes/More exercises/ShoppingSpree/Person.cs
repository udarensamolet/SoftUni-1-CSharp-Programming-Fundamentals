namespace ShoppingSpree
{
    class Person
    {
        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            Products = new List<Product>();
        }

        public string Name { get; set; }
        public double Money { get; set; }
        public List<Product> Products { get; set; }
    }
}
}
