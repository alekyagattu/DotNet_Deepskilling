using Lab2;
using Lab2.Models;
using Microsoft.EntityFrameworkCore;

using var context = new AppDbContext();

context.Database.Migrate(); // Apply migrations

if (!context.Categories.Any())
{
    var clothing = new Category { Name = "Clothing" };
    var electronics = new Category { Name = "Electronics" };

    context.Categories.AddRange(clothing, electronics);

    context.Products.AddRange(
        new Product { Name = "T-Shirt", Price = 299.99m, Category = clothing },
        new Product { Name = "Headphones", Price = 1499.49m, Category = electronics }
    );

    context.SaveChanges();
}

var products = context.Products.Include(p => p.Category).ToList();

foreach (var p in products)
{
    Console.WriteLine($"{p.Name} - ₹{p.Price} ({p.Category.Name})");
}
