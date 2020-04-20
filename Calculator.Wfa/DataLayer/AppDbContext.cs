using Microsoft.EntityFrameworkCore;

namespace Calculator.Wfa.DataLayer
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<CoverageType> CoverageTypes { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }

        public AppDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Catalog;Trusted_Connection=True;");
        }
    }
}
