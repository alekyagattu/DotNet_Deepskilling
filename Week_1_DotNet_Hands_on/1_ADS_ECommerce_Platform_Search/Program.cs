using System;

class Program
{
    static void Main()
    {
        Product[] products = new Product[]
        {
            new Product(101, "Laptop", "Electronics", 49999),
            new Product(102, "Shirt", "Clothing", 999),
            new Product(103, "Watch", "Accessories", 1499),
            new Product(104, "Camera", "Electronics", 39999),
            new Product(105, "Shoes", "Footwear", 1999),
            new Product(106, "Mouse", "Electronics", 599),
            new Product(107, "Shirt", "Clothing", 899),
            new Product(108, "Bag", "Accessories", 1199)
        };

        Console.WriteLine("\n🔎 Choose Search Type:");
        Console.WriteLine("1. Search by Product ID");
        Console.WriteLine("2. Search by Product Name");
        Console.WriteLine("3. Search by Category");
        Console.WriteLine("4. Search by Price Range");
        Console.Write("Enter your choice (1–4): ");
        string? choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Write("Enter Product ID: ");
                int id = int.Parse(Console.ReadLine() ?? "0");
                SearchHelper.SearchById(products, id);
                break;

            case "2":
                Console.Write("Enter Product Name: ");
                string name = Console.ReadLine() ?? "";
                SearchHelper.SearchByName(products, name);
                break;

            case "3":
                Console.Write("Enter Category: ");
                string category = Console.ReadLine() ?? "";
                SearchHelper.SearchByCategory(products, category);
                break;

            case "4":
                Console.Write("Enter Min Price: ");
                double min = double.Parse(Console.ReadLine() ?? "0");
                Console.Write("Enter Max Price: ");
                double max = double.Parse(Console.ReadLine() ?? "0");
                SearchHelper.SearchByPriceRange(products, min, max);
                break;

            default:
                Console.WriteLine("⚠️ Invalid choice.");
                break;
        }

        Console.WriteLine("\n📁 Results saved to SearchResults.txt");
    }
}
