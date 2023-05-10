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
            bool nameExists = Products.Exists(p => p.Name == name);
            if (nameExists)
            {
                Console.WriteLine("Produkt s názvem " + name + " již existuje v inventáři.");
                return;
            }
            Products.Add(new Product(name, price));
        }
        public static void RemoveProduct(string name)
        {
            int index = Products.IndexOf(Products.Find(p => p.Name == name));
            Products.RemoveAt(index);
        }
    }

    public static void Main()
    {
     /*
      
        1.) zeptáš se uživatele, jestli chce smazat/přidat/zobrazit/konec
      

      */
     
        while(true) {
            Console.WriteLine("Vyber operaci (pridat (p), smazat (s), zobrazit (z), konec (k))");
            string input = Console.ReadLine();

            switch(input)
            {
                case "pridat" or "p":
                    {
                        Console.Clear();
                        Console.WriteLine("zadej jméno a cenu:");

                        string name;
                        do
                        {
                            name = Console.ReadLine();

                            if (Inventory.Products.Any(p => p.Name == name))
                            {
                                Console.WriteLine("Produkt s tímto jménem již existuje. Zadej prosím jiné jméno:");
                            }

                        } while (Inventory.Products.Any(p => p.Name == name));

                        double price;
                        bool isPriceValid = double.TryParse(Console.ReadLine(), out price);

                        if (!isPriceValid || price <= 0)
                        {
                            Console.WriteLine("Chybný formát ceny. Zadej prosím celé nezáporné číslo:");
                        }
                        else
                        {
                            Inventory.AddProduct(name, price);
                            Console.WriteLine("Produkt byl úspěšně přidán do inventáře.");
                        }
                    }
                    break;

                case "zobrazit" or "z":
                    {
                        Console.Clear();
                        Console.WriteLine("momentální data jsou:");
                        foreach (var item in Inventory.Products) Console.WriteLine(item.Name + " " + item.Price + " Kč");


                    }
                    break;
                case "smazat" or "s":
                    {
                        Console.Clear();
                        Console.WriteLine("zadej jmeno produktu kterej chces smazat");
                        string name = Console.ReadLine();
                        Inventory.RemoveProduct(name);

                    }
                    break;
                case "konec" or "k":
                    return;
            }
        }
    }


}

