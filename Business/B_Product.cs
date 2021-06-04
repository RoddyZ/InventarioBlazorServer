using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_Product
    {
        //Obtener todos
        public static List<ProductEntity> ProductList()
        {
            using (var db = new InventaryContext())
            {
                return db.Products.ToList();
            }
        }

        //obyener uno
        public static ProductEntity GetProduct(string id)
        {
            using (var db = new InventaryContext())
            {
                return db.Products.ToList().LastOrDefault(p => p.ProductId == id);
            }
        }

        //Crear
        public static void CreateProduct(ProductEntity oProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Add(oProduct);
                db.SaveChanges();
            }
        }

        //ACUTALIZAR
        public static void UpdateProduct(ProductEntity oProduct)
        {
            using (var db = new InventaryContext())
            {
                db.Products.Update(oProduct);
                db.SaveChanges();
            }
        }
    }

}
