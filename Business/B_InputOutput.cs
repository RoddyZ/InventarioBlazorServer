using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business
{
    public class B_InputOutput
    {
        //Obtener lista
        public List<InOutEntity> InOutList()
        {
            using (var db = new InventaryContext())
            {
                return db.InOuts.ToList();
            }
        }

        //cretae list
        public void CreateInOut (InOutEntity oInOut)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Add(oInOut);
                db.SaveChanges();
            }
        }

        //update list
        public void UpdateInOut (InOutEntity oInOurt)
        {
            using (var db = new InventaryContext())
            {
                db.InOuts.Update(oInOurt);
                db.SaveChanges();
            }
        }
    }
}
