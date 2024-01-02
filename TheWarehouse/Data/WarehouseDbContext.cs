using Microsoft.EntityFrameworkCore;
using TheWarehouse.Data.Models;
namespace TheWarehouse.Data
{
    public class WarehouseDbContext : DbContext
    {
        public WarehouseDbContext(DbContextOptions<WarehouseDbContext> options) : base(options) {}
        public DbSet<Supplier> Suppliers => Set<Supplier>();
        public DbSet<Product> Products => Set<Product>();
    }
}
