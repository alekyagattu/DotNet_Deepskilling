using System.Collections.Generic;

namespace Lab3.Models;

public class Category
{
    public int CategoryId { get; set; }
    public string? Name { get; set; }

    public List<Product> Products { get; set; } = new();
}

