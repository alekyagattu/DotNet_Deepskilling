using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab7.Models;

class Program
{
    static async Task Main(string[] args)
    {
        using var context = new AppDbContext();
        await context.Database.MigrateAsync();

        if (!await context.Products.AnyAsync())
        {
            var products = new List<Product>
            {
                new Product { Name = "Laptop", Price = 75000 },
                new Product { Name = "Mobile", Price = 25000 },
                new Product { Name = "Tablet", Price = 18000 },
                new Product { Name = "Pen Drive", Price = 800 },
                new Product { Name = "Headphones", Price = 3500 }
            };

            context.Products.AddRange(products);
            await context.SaveChangesAsync();
            Console.WriteLine("✅ 5 products inserted.");
        }

        Console.WriteLine("\n📦 All Products (Before Filtering):");
        var allProducts = await context.Products.ToListAsync();
        foreach (var p in allProducts)
        {
            Console.WriteLine($"{p.Name} - ₹{p.Price}");
        }

        Console.WriteLine("\n🔍 Filtered & Sorted (Price > 1000, Descending):");
        var filtered = await context.Products
            .Where(p => p.Price > 1000)
            .OrderByDescending(p => p.Price)
            .ToListAsync();

        foreach (var p in filtered)
        {
            Console.WriteLine($"{p.Name} - ₹{p.Price}");
        }

        Console.WriteLine("\n📄 DTO Projection (Name + Price):");
        var productDTOs = await context.Products
            .Select(p => new { p.Name, p.Price })
            .ToListAsync();

        foreach (var dto in productDTOs)
        {
            Console.WriteLine($"{dto.Name} - ₹{dto.Price}");
        }
    }
}
