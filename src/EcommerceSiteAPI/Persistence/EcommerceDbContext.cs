using EcommerceSiteAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceSiteAPI.Persistence
{
    public class EcommerceDbContext : DbContext 
    {
        public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
