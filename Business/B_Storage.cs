using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess;

namespace Business
{
    public static class B_Storage
    {
        
        public static List<StorageEntity> StorageList()
        {
            using (var db = new InventaryContext())
            {
                return db.Storages.ToList();

            }
        }
        public static void CreateStore(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Add(oStorage);
                db.SaveChanges();
            }
        }
        public static void UpdateStore(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storages.Update(oStorage);
                db.SaveChanges();
            }
        }

        public static bool IsProductInWareHouse(string IdStorage)
        {
            using(var db = new InventaryContext())
            {
                var product = db.Storages.ToList().Where(s => s.StorageId == IdStorage);
                var aux = product.Any();
                return aux;
            }           
        }
    }
}
