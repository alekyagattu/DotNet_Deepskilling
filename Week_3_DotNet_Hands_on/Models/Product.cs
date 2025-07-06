namespace Lab1.Models;

public class Product
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
    public int StockLevel { get; set; }
}

