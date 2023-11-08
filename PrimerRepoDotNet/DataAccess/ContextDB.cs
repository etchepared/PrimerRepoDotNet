using Microsoft.EntityFrameworkCore;
using PrimerRepoDotNet.DataAccess.DatabaseSeeding;
using PrimerRepoDotNet.Entities;

namespace PrimerRepoDotNet.DataAccess
{
    public class ContextDB : DbContext
    {
        public ContextDB(DbContextOptions options) : base(options) 
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var seeders = new List<IEntitySeeder> {
            new UserSeeder()
            };

            foreach (var seeder in seeders)
            {
                seeder.SeedDatabase(modelBuilder);
                
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
