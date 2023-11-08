using Microsoft.EntityFrameworkCore;
using PrimerRepoDotNet.Entities;

namespace PrimerRepoDotNet.DataAccess.DatabaseSeeding
{
    public class UserSeeder : IEntitySeeder
    {
        public void SeedDatabase(ModelBuilder modelBuilder) {
            modelBuilder.Entity<User>().HasData(
                    new User
                    {
                        Id = 1,
                        DNI = "32158119",
                        Email = "etcheparede@gmail.com",
                        FirstName = "David",
                        LastName = "Etchepare",
                        IsDeleted = false,
                        Password = "1234"
                    },
                    new User
                    {
                        Id = 2,
                        DNI = "32206717",
                        Email = "natalia@gmail.com",
                        FirstName = "Natalia",
                        LastName = "Cajal",
                        IsDeleted = false,
                        Password = "1234"
                    }
                );
        }
    }
}
