using Microsoft.EntityFrameworkCore;
using CoffeeShopAPI.Models;

namespace CoffeeShopAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<CoffeeShop> CoffeeShops { get; set; }
    }
}
