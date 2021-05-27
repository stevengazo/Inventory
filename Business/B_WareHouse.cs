using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess;
namespace Business
{
    public static class B_WareHouse
    {
        public static List<WareHouseEntity> WareHouseList()
        {
            using (var db = new InventaryContext())
            {
                return db.WareHouses.ToList();
            }
        }
        public  static void CreateWareHouse(WareHouseEntity oWareHouse)
        {
            using (var db = new InventaryContext())
            {
                db.WareHouses.Add(oWareHouse);
                db.SaveChanges();
            }
        }
        public static void  UpdateWareHouse(WareHouseEntity oWareHouse)
        {
            using (var db = new InventaryContext())
            {
                db.WareHouses.Update(oWareHouse);
                db.SaveChanges();
            }
        }
    }
}
