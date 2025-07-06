using Lab1;
using Lab1.Models;
using Microsoft.EntityFrameworkCore;

using var context = new RetailContext();

// Seed sample data if needed
if (!context.Categories.Any())
{
    var electronics = new Category { Name = "Electronics" };
    var groceries = new Category { Name = "Groceries" };

    context.Categories.AddRange(electronics, groceries);
    context.Products.AddRange(
        new Product { Name = "Laptop", Category = electronics, StockLevel = 15 },
        new Product { Name = "Banana", Category = groceries, StockLevel = 100 }
    );
    context.SaveChanges();
}

// Query and display data
var products = context.Products.Include(p => p.Category).ToList();
foreach (var p in products)
{
    Console.WriteLine($"{p.Name} ({p.Category.Name}) - Stock: {p.StockLevel}");
}

