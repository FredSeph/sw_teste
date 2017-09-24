using SWDomain.Interfaces.Business;
using SWDomain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWDomain.Interfaces.Repository;

namespace SWBusiness
{
    public abstract class BusinessBase<T> : IBusinessBase<T> where T : class, IEntity
    {
        #region Properties and Constructors

        private readonly IRepositoryBase<T> _repository;

        public BusinessBase(IRepositoryBase<T> repositoryBase)
        {
            _repository = repositoryBase;
        }

        #endregion

        public int Add(T obj)
        {
            return _repository.Add(obj);
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(object id)
        {
            return _repository.GetById(id);
        }

        public void Update(T obj)
        {
            _repository.Update(obj);
        }

        public void Remove(T obj)
        {
            _repository.Remove(obj);
        }

        public void RemoveById(object parameters)
        {
            _repository.RemoveById(parameters);
        }
    }
}
