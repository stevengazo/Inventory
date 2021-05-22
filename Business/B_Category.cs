using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess;
namespace Business
{
    public class B_Category
    {
        
        public List<CategoryEntity> CategoryList()
        {
            using (var db= new InventaryContext())
            {
                return db.Categories.ToList();
            }       
        }

        public void CreateCategory(CategoryEntity oCategory)
        {
            using( var db = new InventaryContext())
            {
                db.Categories.Add(oCategory);
                db.SaveChanges();
            }
        }

        public void UpdateCategory(CategoryEntity oCategory)
        {
            using (var db = new InventaryContext())
            {
                db.Categories.Update(oCategory);
                db.SaveChanges();
            }
        }
    }
}
