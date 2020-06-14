using System.Collections.Generic;

namespace SilverlightRestWcf.Data
{
    public interface IRepository<T> where T : class
    {
        T GetById(string id);
        IList<T> GetAll();
        void Insert(T entity);
        void Update(T entity);
        void Delete(string id);
    }
}
