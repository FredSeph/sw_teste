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
    public class BusinessBase<T> : IBusinessBase<T> where T : IEntity
    {
        #region Properties and Constructors

        private readonly IRepositoryBase<T> _repositoryBase;

        public BusinessBase(IRepositoryBase<T> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        #endregion

        public int Add(T obj)
        {
            return _repositoryBase.Add(obj);
        }

        public IEnumerable<T> GetAll(bool orderByName = false)
        {
            return _repositoryBase.GetAll(orderByName);
        }

        public void Update(T obj)
        {
            _repositoryBase.Update(obj);
        }

        public void Remove(T obj)
        {
            _repositoryBase.Remove(obj);
        }

        public void RemoveById(object parameters)
        {
            _repositoryBase.RemoveById(parameters);
        }
    }
}
