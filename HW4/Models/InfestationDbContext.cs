using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HW4.Models
{
    public class InfestationDbContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Human> Humans { get; set; }
        private IConfiguration _configuration { get; }
        public InfestationDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSQLServer
            optionsBuilder.UseMySql(_configuration.GetConnectionString("InfestationDbConnectionNew"));
        }
    }
}
