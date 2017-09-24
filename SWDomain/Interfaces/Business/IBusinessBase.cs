using SWDomain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWDomain.Interfaces.Business
{
    public interface IBusinessBase<T> where T : class, IEntity
    {
        int Add(T obj);
        IEnumerable<T> GetAll();
        T GetById(object id);
        void Update(T obj);
        void Remove(T obj);
        void RemoveById(object parameters);
    }
}
