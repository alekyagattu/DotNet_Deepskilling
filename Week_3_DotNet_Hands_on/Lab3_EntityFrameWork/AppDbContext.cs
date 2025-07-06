using Microsoft.EntityFrameworkCore;
using Lab3.Models;

namespace Lab3;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Category> Categories => Set<Category>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
    "Server=localhost,1433;Database=Lab3Db;User Id=SA;Password=@Alekya06;Encrypt=True;TrustServerCertificate=True;"
);

    }
}
