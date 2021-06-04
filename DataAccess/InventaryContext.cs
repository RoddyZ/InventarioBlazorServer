using Entities;//agregue la dependencia de proyecto
using Microsoft.EntityFrameworkCore; //esta libreria se instalo con Nuget
using System;
using System.Collections.Generic;
using System.Text;

//Conexión directa a la base de datos
namespace DataAccess
{

    public class InventaryContext : DbContext
    {
        //tablas de la base de ddatos (todas se tratan como listas)
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<InOutEntity> InOuts { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }
        public DbSet<WarehouseEntity> Warehouses { get; set; }
    
        //conectamos la base de datos
        protected override void OnConfiguring(DbContextOptionsBuilder option) 
        {
            //si no esta configurado hacemos....
            if (!option.IsConfigured)
            {
                //option.UseSqlServer("Server=SQLEXPRESS;Database=InventaryDb; User Id=RSZR; Password=110397pes");
                //autenticacion de Windows (el arroba es full importante)
                option.UseSqlServer(@"Server = DESKTOP-QS8JAED\SQLEXPRESS; Database = InventaryDb; Trusted_Connection = True");
            }
        }

        //probamos datos desde C# con ENTITYFramework
        //con este metodo creamos los datos a las tablas en SQL
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId="ASH",CategoryName="Aseo Hogar"},
                new CategoryEntity { CategoryId = "PRF", CategoryName = "Perfumeria" },
                new CategoryEntity { CategoryId = "ASP", CategoryName = "Aseo Personal" },
                new CategoryEntity { CategoryId = "HGR", CategoryName = "Hogar" },
                new CategoryEntity { CategoryId = "SLD", CategoryName = "SALUD" }

                );
            modelBuilder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity { WarehouseId=Guid.NewGuid().ToString(), WarehouseName="BodegaCentral",WarehouseAddress="Quito"},
                new WarehouseEntity { WarehouseId = Guid.NewGuid().ToString(), WarehouseName = "Bodega Lateral", WarehouseAddress = "GYE" }

                );
        }

        
    
    
    }


}
