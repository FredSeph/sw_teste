using SWDomain.Interfaces.Repository;
using SWDomain.Model;
using SWDomain.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWRepository.Data
{
    class RepositoryBase<T> : IRepositoryBase<T> where T : IEntity
    {
        public int Add(T obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetByFields(object parameters)
        {
            using (var model = new SWModel())
            {
                var result = new List<T>();
                //var result = model./* preciso do T aqui */.Where(/* parameters em lambda expression */).ToList();
                return result;
            }
        }

        public IEnumerable<T> GetAll(object parameters)
        {
            throw new NotImplementedException();
        }

        public void Remove(T obj)
        {
            throw new NotImplementedException();
        }

        public void RemoveById(object parameters)
        {
            throw new NotImplementedException();
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
