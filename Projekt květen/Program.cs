class Diamond
{
  

    public class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; } = "";
        public double Price { get; set; }
    }
    public static class Inventory
    {
        public static List<Product> Products = new List<Product>();
        public static int Count { get; set; }
        public static void AddProduct(string name, double price)
        {
            Products.Add(new Product(name, price));
        }
        /*public static void RemoveProduct(string name, double price)
        {
            Products.Remove(new Product(name, price));

        }*/
    }

    public static void Main()
    {
     /*
      
        1.) zeptáš se uživatele, jestli chce smazat/přidat/zobrazit/konec
      

      */
     
        while(true) {
            Console.WriteLine("Vyber operaci (pridat, smazat, zobrazit, konec)");
            string input = Console.ReadLine();

            switch(input)
            {
                case "pridat":
                    {
                        // uzivatel zadá input (jmeno, cenu)
                        string name = Console.ReadLine();
                        int price = int.Parse(Console.ReadLine());
                        Inventory.AddProduct(name, price);
                        Console.Clear();
                    }break;
                case "smazat":
                    {
                        Console.WriteLine("momentální data jsou:");
                        foreach (var item in Inventory.Products) ;
                        

                    }
                    break;

            }
        }
    }


}

