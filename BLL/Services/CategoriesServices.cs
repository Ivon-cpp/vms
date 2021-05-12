using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using BLL.ViewModels;

namespace BLL.Services
{
    class CategoriesServices : ICategoriesService
    {
        public CategoriesViewModel GetAllCategoriesVm()
        {
            return new CategoriesViewModel();
        }
    }
}
