class Diamond
{
    private class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; } = "";
        public double Price { get; set; }
    }
    private static class Inventory
    {
        public static List<Product> Products { get; set; } = new List<Product>();
        public static int Count { get; set; }
        public static void AddProduct(string name, double price)
        {
            Products.Add(new Product(name, price));
        }
        public static void RemoveProduct(string name, double price)
        {
            Products.Remove(new Product(name, price));

        }
    }

    public static void Main()
    {
        
    }
}

