using Microsoft.EntityFrameworkCore;
using Sliit.MTIT_100.Seller.Models;
using Microsoft.EntityFrameworkCore;

namespace Sliit.MTIT_100.Seller.Data
{
    public class DbContextClass : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DbContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Models.Seller> Sellers { get; set; }
    }
}
