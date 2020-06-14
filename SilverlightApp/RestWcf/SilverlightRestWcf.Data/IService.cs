using System.Collections.Generic;
using System.ServiceModel;

namespace SilverlightRestWcf.Data
{
    [ServiceContract]
    interface IService<T>
    {
        [OperationContract]
        IList<T> GetAll();
        
        [OperationContract]
        T Get(string id);
      
        [OperationContract]
        void Insert(T entity);
      
        [OperationContract]
        void Update(string id, T entity);
     
        [OperationContract]
        void Delete(string id);
    }
}
