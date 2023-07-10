using Microsoft.EntityFrameworkCore;
using Sliit.MTIT_100.Customer.Model;


namespace Sliit.MTIT_100.Customer.Data
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
        public DbSet<Model.Customer> Customer { get; set; }
    }
}

