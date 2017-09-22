using SWDomain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWDomain.Interfaces.Repository
{
    public interface IRepositoryBase<T> where T : IEntity
    {
        int Add(T obj);
        IEnumerable<T> GetAll(bool orderByName = false);
        void Update(T obj);
        void Remove(T obj);
        void RemoveById(object parameters);
    }
}
