using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess;
namespace Business
{
    public static class B_Category
    {
        
        public static List<CategoryEntity> CategoryList()
        {
            using (var db= new InventaryContext())
            {
                return db.Categories.ToList();
            }       
        }

        public static void CreateCategory(CategoryEntity oCategory)
        {
            using( var db = new InventaryContext())
            {
                db.Categories.Add(oCategory);
                db.SaveChanges();
            }
        }

        public static void UpdateCategory(CategoryEntity oCategory)
        {
            using (var db = new InventaryContext())
            {
                db.Categories.Update(oCategory);
                db.SaveChanges();
            }
        }
    }
}
