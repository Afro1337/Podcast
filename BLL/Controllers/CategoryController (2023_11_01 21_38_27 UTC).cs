using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL.Repository;

namespace BLL
{
    public class ControllerCategory
    {
        RepositoryCategory repositoryCategory;
        List<Category> categoryList;

        public ControllerCategory()
        {
            repositoryCategory = new RepositoryCategory();
            categoryList = repositoryCategory.GetAll();
        }

        public void DeleteCategory(string name)
        {
            int index = repositoryCategory.GetIndex(name);
            repositoryCategory.Delete(index);
        }

        public void CreateCategory(Category category)
        {
            repositoryCategory.Create(category);
        }

        public void UpdateCategory(int index, Category category)
        {
            repositoryCategory.Update(index, category);
        }

        public List<Category> GetAll()
        {
            return repositoryCategory.GetAll();
        }
    }
}
