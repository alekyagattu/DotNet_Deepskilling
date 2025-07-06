using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab6.Models;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Lab6Db;User Id=sa;Password=@Alekya06;TrustServerCertificate=True;");
    }
}

class Program
{
    static async Task Main()
    {
        using var context = new AppDbContext();

        // Check existing product count
        var allProducts = await context.Products.Include(p => p.Category).ToListAsync();
        Console.WriteLine($"\n📸 BEFORE UPDATES");
        Console.WriteLine($"📦 Total Products in DB: {allProducts.Count}");
        foreach (var p in allProducts)
            Console.WriteLine($"{p.Name} - ₹{p.Price} - Category: {p.Category?.Name}");

        // Update: Change price of Laptop
        var laptop = await context.Products.FirstOrDefaultAsync(p => p.Name == "Laptop");
        if (laptop != null)
        {
            laptop.Price = 70000;
            Console.WriteLine($"\n✏️ Updated: Laptop price to ₹70000");
        }

        // Delete: Rice Bag and Tablet
        var riceBag = await context.Products.FirstOrDefaultAsync(p => p.Name == "Rice Bag");
        var tablet = await context.Products.FirstOrDefaultAsync(p => p.Name == "Tablet");

        if (riceBag != null) context.Products.Remove(riceBag);
        if (tablet != null) context.Products.Remove(tablet);

        await context.SaveChangesAsync();

        // Display final products
        var finalProducts = await context.Products.Include(p => p.Category).ToListAsync();
        Console.WriteLine($"\n✅ AFTER DELETION/UPDATE");
        Console.WriteLine($"📦 Remaining Products in DB: {finalProducts.Count}");
        foreach (var p in finalProducts)
            Console.WriteLine($"{p.Name} - ₹{p.Price} - Category: {p.Category?.Name}");
    }
}
