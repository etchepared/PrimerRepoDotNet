﻿using Microsoft.EntityFrameworkCore;//hay que instalar
//Herramientas/Administrador de paquetes Nuget/Administrar paquetes Nuget para la solución
//buscamos EntityFramework e instalamos:
//Microsoft.EntityFrameworkCore >Seleccionar versión 6
//Microsoft.EntityFrameworkCore.SqlServer
//Microsoft.EntityFrameworkCore.Tools
//Microsoft.EntityFrameworkCore.Design
using PrimerRepoDotNet.Entities;

namespace PrimerRepoDotNet.DataAccess.DatabaseSeeding
{
    public class UserSeeder : IEntitySeeder
    {
        public void SeedDatabase(ModelBuilder modelBuilder) 
        {
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
//completado el seeder probar si funciona con el migration
//abrimos la consola desde Herramientas/Administrador de paquetes nuget/Consola del administrador de paquetes
//utilizamos el comando add-migration Version1 (el nombre lo elegimos nosotros)
//luego Update-Database