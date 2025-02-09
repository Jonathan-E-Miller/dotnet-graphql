using Microsoft.EntityFrameworkCore;
using Repository.Models;

namespace Repository;

public class ContosoDbContext : DbContext
{
    public DbSet<DimProduct> DimProducts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Contoso;User Id=sa;Password=YourStrong!Passw0rd; TrustServerCertificate=true");
    }
}
