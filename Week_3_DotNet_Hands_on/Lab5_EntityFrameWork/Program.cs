using System;
using System.Linq; // ✅ This is required for .Any()
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab5.Models;

class Program
{
    static async Task Main()
    {
        using var context = new AppDbContext();

        // ✅ Insert initial data if database is empty
        if (!context.Products.Any())
        {
            var electronics = new Category { Name = "Electronics" };
            var groceries = new Category { Name = "Groceries" };

            await context.Categories.AddRangeAsync(electronics, groceries);

            var product1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
            var product2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };

            await context.Products.AddRangeAsync(product1, product2);
            await context.SaveChangesAsync();

            Console.WriteLine("✅ Data inserted successfully.");
        }

        // 📦 Retrieve all products
        var products = await context.Products.ToListAsync();
        Console.WriteLine("\n📦 All Products:");
        foreach (var p in products)
        {
            Console.WriteLine($"{p.Name} - ₹{p.Price}");
        }

        // 🔍 Find product by ID
        var productById = await context.Products.FindAsync(1);
        Console.WriteLine($"\n🔍 Found by ID: {productById?.Name}");

        // 💰 First product with price > 50000
        var expensiveProduct = await context.Products.FirstOrDefaultAsync(p => p.Price > 50000);
        Console.WriteLine($"\n💰 Expensive Product: {expensiveProduct?.Name}");
    }
}
