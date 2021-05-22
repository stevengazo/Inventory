﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess;
namespace Business
{
    public class B_InOut
    {
       
        public List<InputOutputEntity> InOutList()
        {
            using( var db = new InventaryContext())
            {
                return db.InOut.ToList();
            }
        }

        public void CreateInOut (InputOutputEntity oInOut)
        {
            using (var db = new InventaryContext())
            {
                db.InOut.Add(oInOut);
                db.SaveChanges();
            }
        }

        public void Update (InputOutputEntity oInOut)
        {
            using (var db = new InventaryContext())
            {
                db.InOut.Update(oInOut);
                db.SaveChanges();
            }
        }
    }
}
