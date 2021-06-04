using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using System.Linq;

namespace Business
{
    public class B_Category
    {
        //se llama una lista de datos GetTodaLaLista
        public static List<CategoryEntity> CategoryList() 
        {
            //db es un objeto InventaryContext (tabla base datos)
             using (var db = new InventaryContext())
            {
                return db.Categories.ToList();
            }
        }

        //create 
        public static void CreateCategory(CategoryEntity oCategory)
        {
            //using para tener un ciclo de incio y fin, se cierra la coonexion al final
            using(var db = new InventaryContext())
            {
                db.Categories.Add(oCategory);
                db.SaveChanges(); //guardo cambios a la base
            }
        }

        //Update
        public static void UpdateCategory(CategoryEntity oCategory)
        {
            using(var db = new InventaryContext())
            {
                //el mismo identificara el id,y lo llenara con los datos nuevos
                db.Categories.Update(oCategory);
                db.SaveChanges();
            }
        }
    }
}
