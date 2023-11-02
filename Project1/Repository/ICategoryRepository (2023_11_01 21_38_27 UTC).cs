using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        void Create(T entity);
        void Delete(int index);
        void Update(int index, T entity);
        void SaveChanges();
    }
}
