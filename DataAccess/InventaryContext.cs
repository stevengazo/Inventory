using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Entities;

namespace DataAccess
{
    public class InventaryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<WareHouseEntity> WareHouses { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<InputOutputEntity> InOut { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=(Local);Database=InventoryDBTesting;User Id=TestingUserDb; Password=TestingUserDb1");
            }
        }

        /// <summary>
        /// Cargado de datos en la DB
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CategoryEntity>().HasData(
                    new CategoryEntity { CategoryId = "ASH", CategoryName = "Aseo Hogar" },
                    new CategoryEntity { CategoryId = "ASP", CategoryName = "Aseo Personal" },
                    new CategoryEntity { CategoryId = "HGR", CategoryName = "Hogar" }             
            );
            modelBuilder.Entity<WareHouseEntity>().HasData(
                    new WareHouseEntity {   WareHouseId= Guid.NewGuid().ToString(),
                                            WareHouseName="Bodega Central",
                                            WareHouseAddress="San Miguel"},
                    new WareHouseEntity {   WareHouseId = Guid.NewGuid().ToString(), 
                                            WareHouseName = "Bodega Auxiliar", 
                                            WareHouseAddress = "San Luis" }
            ) ;
            
        }
    }
}
