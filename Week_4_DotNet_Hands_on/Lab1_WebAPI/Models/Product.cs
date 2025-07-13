namespace Lab1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; } // nullable to avoid warning
        public double Price { get; set; }
    }
}
