using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using DAL.Interfaces;
using DAL.ORM;

namespace DAL.Repositories
{
    public class CategoriesRepositories : ICategoryRepository
    {
        private DataManager dm = new DataManager();


        public void AddCategory(Category newCategory)
        {
            dm.Categories.Add(newCategory);
            dm.SaveChanges();
        }
        public void DelCategory(int delCategoryId)
        {
            var delCategory = dm.Categories.Where(c => c.Id == delCategoryId).FirstOrDefault();
            if (delCategory != null) dm.Categories.Remove(delCategory);
            dm.SaveChanges();
        }
        public IEnumerable<Category> GetAllCategories()
        {
            return dm.Categories.ToList();
        }
    }
}
