using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class B_Storage
    {
        //GetTodaLaLista
        public static List<StorageEntity> EntityList()
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.ToList();
            }
        }



        //Create Storage
        public static void CreateStorage(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Add(oStorage);
                db.SaveChanges();
            }
        }

        //verificara si el producto ya edsta en la bodega

        public static bool IsProductInWareHouse(string idStorage)
        {
            using (var db = new InventaryContext())
            {
                var product = db.Storages.ToList().Where(s => s.StorageId == idStorage);
                return product.Any(); //se existe un producto q este bodega retorna true
            }

        }
        //update Storage
        public static void UpdateStorage(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Update(oStorage);
                db.SaveChanges();
            }
        }


        //obetenmos un listado segun el id de la bodega
        
        public static List<StorageEntity> StorageProductByWarehouse(string idWareHouse)
        {
            using (var db = new InventaryContext())
            {
                return db.Storages 
                    .Include(s => s.Product)                   //incluimos los productos de la bodega
                    .Include(s => s.Warehouse)                  //incluimos los warehouese de la bodega
                    .Where(s => s.WarehouseId == idWareHouse)  //Where LINQ s(storage Entity)
                    .ToList();
            }
        }
    }
}
