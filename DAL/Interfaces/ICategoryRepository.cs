using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ICategoryRepository
    {
        void AddCategory(Category newCategory);
        void DelCategory(int delCategoryId);
        IEnumerable<Category> GetAllCategories();
    }
}
