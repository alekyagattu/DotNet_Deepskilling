using System;
using System.Diagnostics;
using System.Linq;

public static class SearchHelper
{
    public static void SearchById(Product[] products, int id)
    {
        var stopwatch = Stopwatch.StartNew();

        var product = products.FirstOrDefault(p => p.Id == id);
        stopwatch.Stop();

        Logger.LogHeader($"🔍 Search Result – Product ID: {id}");
        if (product != null)
            Logger.LogResult(product.ToString());
        else
            Logger.LogResult("❌ Product not found.");

        Logger.LogResult($"⌛ Time Complexity: O(n), Time Taken: {stopwatch.Elapsed.TotalMilliseconds:F4} ms");
        Logger.LogFooter();
    }

    public static void SearchByName(Product[] products, string name)
    {
        var stopwatch = Stopwatch.StartNew();

        var matches = products
            .Where(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            .ToList();

        stopwatch.Stop();

        Logger.LogHeader($"🔍 Search Results – Product Name: {name}");
        if (matches.Count > 0)
        {
            foreach (var product in matches)
                Logger.LogResult(product.ToString());
        }
        else
            Logger.LogResult("❌ No products found.");

        Logger.LogResult($"⌛ Time Complexity: O(n), Time Taken: {stopwatch.Elapsed.TotalMilliseconds:F4} ms");
        Logger.LogFooter();
    }

    public static void SearchByCategory(Product[] products, string category)
    {
        var stopwatch = Stopwatch.StartNew();

        var matches = products
            .Where(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
            .ToList();

        stopwatch.Stop();

        Logger.LogHeader($"📂 Search Results – Category: {category}");
        if (matches.Count > 0)
        {
            foreach (var product in matches)
                Logger.LogResult(product.ToString());
        }
        else
            Logger.LogResult("❌ No products found.");

        Logger.LogResult($"⌛ Time Complexity: O(n), Time Taken: {stopwatch.Elapsed.TotalMilliseconds:F4} ms");
        Logger.LogFooter();
    }

    public static void SearchByPriceRange(Product[] products, double minPrice, double maxPrice)
    {
        var stopwatch = Stopwatch.StartNew();

        var filtered = products
            .Where(p => p.Price >= minPrice && p.Price <= maxPrice)
            .ToList();

        stopwatch.Stop();

        Logger.LogHeader($"📦 Search Results – Price Range: ₹{minPrice} – ₹{maxPrice}");
        foreach (var product in filtered)
            Logger.LogResult(product.ToString());

        if (filtered.Count == 0)
            Logger.LogResult("❌ No products found.");

        Logger.LogResult($"⌛ Time Complexity: O(n), Time Taken: {stopwatch.Elapsed.TotalMilliseconds:F4} ms");
        Logger.LogFooter();
    }
}
