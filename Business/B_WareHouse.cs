using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess;
namespace Business
{
    public class B_WareHouse
    {
        public List<WareHouseEntity> WareHouseList()
        {
            using (var db = new InventaryContext())
            {
                return db.WareHouses.ToList();
            }
        }
        public void CreateWareHouse(WareHouseEntity oWareHouse)
        {
            using (var db = new InventaryContext())
            {
                db.WareHouses.Add(oWareHouse);
                db.SaveChanges();
            }
        }
        public void UpdateWareHouse(WareHouseEntity oWareHouse)
        {
            using (var db = new InventaryContext())
            {
                db.WareHouses.Update(oWareHouse);
                db.SaveChanges();
            }
        }
    }
}
