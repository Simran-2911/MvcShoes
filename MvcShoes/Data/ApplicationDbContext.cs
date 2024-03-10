using Microsoft.EntityFrameworkCore;
using MvcShoes.Models; // Add this line to include the Models namespace

namespace MvcShoes.Data
{
    public class ApplicationDbContext : DbContext    {
        public DbSet<Product> Product { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        { }
    }
}
