using Microsoft.EntityFrameworkCore;
using Lab7.Models;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Lab7Db;User Id=sa;Password=@Alekya06;TrustServerCertificate=True;");
    }
}
