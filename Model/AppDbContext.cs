using Microsoft.EntityFrameworkCore;

namespace finshark.Model;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Stock> Stocks { get; set; } = null!;
    public DbSet<Comment> Comments { get; set; } = null!;
}