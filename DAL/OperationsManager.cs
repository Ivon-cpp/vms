using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;

namespace DAL
{
    public class OperationsManager
    {
        public CategoriesRepositories CategoriesRepos { get; set; }
        public DoctorsRepository DoctorsRepos { get; set; }

        public OperationsManager()
        {
            CategoriesRepos = new CategoriesRepositories();
            DoctorsRepos = new DoctorsRepository();
        }
    }
}
