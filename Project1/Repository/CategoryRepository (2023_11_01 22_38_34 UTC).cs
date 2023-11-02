using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;


namespace DAL.Repository
{
    public class RepositoryCategory : IRepository<Category>
    {
        SerializerXML dataManager;
        List<Category> categoryList;

        public RepositoryCategory()
        { 
            dataManager = new SerializerXML();
            categoryList = new List<Category>();
            categoryList = GetAll();
        }
        public List<Category> GetAll()
        {
            List<Category> categoryList = new List<Category>();

            try
            {
                categoryList = dataManager.DeserializeCategory();
            }
            catch (ExceptionSerializer error)
            {
                Console.WriteLine(error.Message + ". No list found");
            }

            return categoryList;
        }

        public void Create(Category category)
        { 
            categoryList.Add(category);
            SaveChanges();
        }

        public void Delete(int index)
        { 
            categoryList.RemoveAt(index);
            SaveChanges();
        }

        public void Update(int index, Category category)
        { 
            if (index >= 0)
            {
                categoryList[index] = category;
            }

            SaveChanges();
        }

        public int GetIndex(string name) 
        { 
            return GetAll().FindIndex(x => x.Name.Equals(name));
        }

        public void SaveChanges()
        {
            dataManager.SerializeCategory(categoryList);
        }

    }
}
