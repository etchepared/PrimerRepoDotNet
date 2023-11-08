using Microsoft.EntityFrameworkCore;

namespace PrimerRepoDotNet.DataAccess.DatabaseSeeding
{
    public interface IEntitySeeder
    {
        void SeedDatabase(ModelBuilder modelBuilder);
    }
}
