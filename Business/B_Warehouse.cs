using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Warehouse
    {
        //Get todas las WareList
        public static List<WarehouseEntity> WarehouseList()
        {
            using (var db = new InventaryContext())
            {
                return db.Warehouses.ToList();
            }
        }

        //Create Warehouse
        public static void CreateWarehouse(WarehouseEntity oWarehouse)
        {
            using (var db = new InventaryContext())
            {
                db.Warehouses.Add(oWarehouse);
                db.SaveChanges();
            }
        }

        //Update Warehouse
        public static void UpdateWarehouse(WarehouseEntity oWarehouse)
        {
            using(var db = new InventaryContext())
            {
                db.Warehouses.Update(oWarehouse);
                db.SaveChanges();
            }
        }
    }
}
