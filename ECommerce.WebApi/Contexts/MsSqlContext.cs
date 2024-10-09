using ECommerce.WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.WebApi.Contexts;

public class MsSqlContext : DbContext
{

    public MsSqlContext(DbContextOptions opt) : base(opt)
    {
        
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1907; Database=Ecommerce_db; User=sa; Password=deneme123; TrustServerCertificate=true");
    }

    public DbSet<Product> Products { get; set; }

}
